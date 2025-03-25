using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using PostalCW.DataStructures;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PostalCW

{
    public partial class Clients : Form
    {


        private HashTable<Client> clientTable = new HashTable<Client>();
        private int selectedClientID = -1; // Track client ID
        public string connectionString = @"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public Clients()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize columns 
            LoadFromDatabase(); // Load clients into hash table from SQL
            LoadClientData(); // Display clients 

        }


        // Apply Rounded Corners
        private void Clients_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            ApplyRoundedEdges(this, 50);
            ApplyRoundedEdges(panel1, 30);
            ApplyRoundedEdges(clientTableLayout, 30);
            ApplyRoundedEdges(panel3, 30);
            ApplyRoundedEdges(panel4, 30);
            ApplyRoundedEdges(panel7, 50);

        }

        private void ApplyRoundedEdges(Control control, int radius)
        {
            if (control == null) return;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }




        // == SETUP DATA GRID VIEW COLUMNS == //
        private void InitializeDataGridView()
        {
            clientDataGridView.Columns.Clear();
            clientDataGridView.ColumnCount = 6;

            clientDataGridView.Columns[0].Name = "ClientID";
            clientDataGridView.Columns[1].Name = "ClientName";
            clientDataGridView.Columns[2].Name = "ClientNID";
            clientDataGridView.Columns[3].Name = "ClientContact";
            clientDataGridView.Columns[4].Name = "Email";
            clientDataGridView.Columns[5].Name = "ClientAddress";

            //Column for images
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "NIDpic";
            imgColumn.HeaderText = "NID Image";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            clientDataGridView.Columns.Add(imgColumn);

            clientDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // == LOAD CLIENTS FROM SQL DATABASE INTO HASH TABLE == //
        private void LoadFromDatabase()
        {
            clientTable = new HashTable<Client>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ClientsTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Client client = new Client
                    {
                        ClientID = reader.GetInt32(0),
                        ClientName = reader.GetString(1),
                        ClientNID = reader.GetString(2),
                        ClientContact = reader.GetInt32(3).ToString(),
                        Email = reader.GetString(4),
                        ClientAddress = reader.GetString(5),
                        NIDpic = (reader["NIDpic"] != DBNull.Value) ? ByteArrayToImage((byte[])reader["NIDpic"]) : null
                    };

                    clientTable.Insert(client.ClientID, client);
                }
            }
        }

        // == LOAD CLIENTS INTO DATA GRID VIEW == //
        private void LoadClientData()
        {
            clientDataGridView.Rows.Clear(); // Clear existing rows

            foreach (Client client in clientTable.GetAll()) // Fetch from hash table
            {
                object img = client.NIDpic ?? new Bitmap(1, 1);
                clientDataGridView.Rows.Add(client.ClientID, client.ClientName, client.ClientNID,
                                            client.ClientContact, client.Email, client.ClientAddress, img);
            }
        }

        // == INSERT CLIENT INTO DATABASE == //
        private int InsertIntoDatabase(Client client)
        {
            int newClientID = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ClientsTbl (ClientName, ClientNID, ClientContact, Email, ClientAdress, NIDpic) " +
                    "OUTPUT INSERTED.ClientID " + // Retrieves the new ClientID
                    "VALUES (@ClientName, @ClientNID, @ClientContact, @Email, @ClientAdress, @NIDpic)", con);

                cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                cmd.Parameters.AddWithValue("@ClientNID", client.ClientNID);
                cmd.Parameters.AddWithValue("@ClientContact", client.ClientContact);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@ClientAdress", client.ClientAddress);
                cmd.Parameters.AddWithValue("@NIDpic", ImageToByteArray(client.NIDpic));

                newClientID = (int)cmd.ExecuteScalar(); // Get the actual ClientID from SQL
            }

            return newClientID; // Return the correct ClientID
        }

        // == UPDATE CLIENT IN DATABASE == //
        private void UpdateDatabase(Client client)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE ClientsTbl SET ClientName=@ClientName, ClientNID=@ClientNID, ClientContact=@ClientContact, " +
                    "Email=@Email, ClientAdress=@ClientAdress, NIDpic=@NIDpic WHERE ClientID=@ClientID", con);

                cmd.Parameters.AddWithValue("@ClientID", client.ClientID);
                cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                cmd.Parameters.AddWithValue("@ClientNID", client.ClientNID);
                cmd.Parameters.AddWithValue("@ClientContact", client.ClientContact);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@ClientAdress", client.ClientAddress);
                cmd.Parameters.AddWithValue("@NIDpic", ImageToByteArray(client.NIDpic)); // Convert image to byte array

                cmd.ExecuteNonQuery();
            }
        }


        // == SAVE BUTTON == //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClientName.Text) || string.IsNullOrWhiteSpace(ClientNID.Text) ||
                string.IsNullOrWhiteSpace(ClientContact.Text) || string.IsNullOrWhiteSpace(ClientEmail.Text) ||
                string.IsNullOrWhiteSpace(ClientAddress.Text))
            {
                MessageBox.Show("Incomplete Data");
                return;
            }

            Client newClient = new Client
            {
                ClientID = selectedClientID,
                ClientName = ClientName.Text,
                ClientNID = ClientNID.Text,
                ClientContact = ClientContact.Text,
                Email = ClientEmail.Text,
                ClientAddress = ClientAddress.Text,
                NIDpic = ClientIDpic.Image
            };

            if (selectedClientID == -1)  
            {
                newClient.ClientID = InsertIntoDatabase(newClient);  
                clientTable.Insert(newClient.ClientID, newClient);
            }
            else
            {
                UpdateDatabase(newClient);
                clientTable.Remove(selectedClientID);
                clientTable.Insert(newClient.ClientID, newClient);
            }

            MessageBox.Show("Client saved successfully!");
            LoadClientData();
            ResetFields();
        }


        // == EDIT BUTTON == //
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to edit.");
                return;
            }

            selectedClientID = Convert.ToInt32(clientDataGridView.SelectedRows[0].Cells["ClientID"].Value);
            Client selectedClient = clientTable.Get(selectedClientID);

            if (selectedClient != null)
            {
                ClientName.Text = selectedClient.ClientName;
                ClientNID.Text = selectedClient.ClientNID;
                ClientContact.Text = selectedClient.ClientContact;
                ClientEmail.Text = selectedClient.Email;
                ClientAddress.Text = selectedClient.ClientAddress;
                ClientIDpic.Image = selectedClient.NIDpic;
            }
        }

        // == UPLOAD IMAGE == //
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClientIDpic.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // == DELETE BUTTON == //
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            int clientID = Convert.ToInt32(clientDataGridView.SelectedRows[0].Cells["ClientID"].Value);
            DeleteFromDatabase(clientID);
            clientTable.Remove(clientID);

            MessageBox.Show("Client Deleted Successfully!");
            LoadClientData(); // Refresh DataGridView
        }

        // == DELETE CLIENT FROM DATABASE == //
        private void DeleteFromDatabase(int clientID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ClientsTbl WHERE ClientID = @ClientID", con);
                cmd.Parameters.AddWithValue("@ClientID", clientID);
                cmd.ExecuteNonQuery();
            }
        }

        // == IMAGE CONVERSION METHODS == //
        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img?.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // == RESET FIELDS == //
        private void ResetFields()
        {
            selectedClientID = -1;
            ClientName.Clear();
            ClientNID.Clear();
            ClientContact.Clear();
            ClientEmail.Clear();
            ClientAddress.Clear();
            ClientIDpic.Image = null;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

    }

    // Client Class (Outside Clients Form) //
    public class Client
    {
        public int ClientID { get; set; }
        public string? ClientName { get; set; }
        public string? ClientNID { get; set; }
        public string? ClientContact { get; set; }
        public string? Email { get; set; }
        public string? ClientAddress { get; set; }
        public Image? NIDpic { get; set; } 
    }
}
