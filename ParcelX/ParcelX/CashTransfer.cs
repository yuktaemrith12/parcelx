using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using PostalCW.DataStructures;

namespace PostalCW
{
    public partial class CashTransfer : Form
    {
        // Database connection
        private SqlConnection Con = new SqlConnection(@"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        // Hash Table 
        private HashTable<Transfer> transferTable = new HashTable<Transfer>();
        private int selectedTransferID = -1; 


        public CashTransfer()
        {
            InitializeComponent();
            InitializeSearchFeature(); // Set up search feature for Sender Name
            LoadFromDatabase(); // Load transactions from DB to hash table
            LoadTransactionData(); // Display transactions in DataGridView
            InitializeDataGridView();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(CashTransfer_Load);
        }

        private void CashTransfer_Load(object sender, EventArgs e)
        {
            ApplyRoundedEdges(this, 50);
            ApplyRoundedEdges(panel1, 30);
            ApplyRoundedEdges(panel2, 30);
            ApplyRoundedEdges(panel3, 30);
            ApplyRoundedEdges(panel4, 30);

            // Load transactions to display them in DataGridView
            LoadFromDatabase();
            LoadTransactionData();
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

        // == SEARCH FEATURE ==//
        private void InitializeSearchFeature()
        {
            senderName.DropDownStyle = ComboBoxStyle.DropDown; // Allows typing & selection
            senderName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            senderName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection senderNamesCollection = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientID, ClientName FROM ClientsTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                //  Load names into ComboBox & AutoComplete
                while (reader.Read())
                {
                    string clientName = reader["ClientName"].ToString();
                    int clientID = Convert.ToInt32(reader["ClientID"]);

                    senderNamesCollection.Add(clientName);
                    senderName.Items.Add(clientName); // Add names to ComboBox
                }
            }

            senderName.AutoCompleteCustomSource = senderNamesCollection;

            // Update Sender ID on selection change
            senderName.SelectedIndexChanged += (s, e) => UpdateSenderID();
            senderName.TextChanged += (s, e) => UpdateSenderID();
        }

        // Helper method to update Sender ID when a name is selected
        private void UpdateSenderID()
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientID FROM ClientsTbl WHERE ClientName = @ClientName", con);
                cmd.Parameters.AddWithValue("@ClientName", senderName.Text);

                object result = cmd.ExecuteScalar();
                senderID.Text = (result != null) ? result.ToString() : "";
            }
        }




        // Define columns for the DataGridView
        private void InitializeDataGridView()
        {
            dataGridTransfer.Columns.Clear();

            dataGridTransfer.ColumnCount = 10; 

            dataGridTransfer.Columns[0].Name = "TransferID";
            dataGridTransfer.Columns[1].Name = "TransferDate";
            dataGridTransfer.Columns[2].Name = "Amount";
            dataGridTransfer.Columns[3].Name = "TransferType";
            dataGridTransfer.Columns[4].Name = "TransferPurpose";
            dataGridTransfer.Columns[5].Name = "SenderID";
            dataGridTransfer.Columns[6].Name = "ReceiverName";
            dataGridTransfer.Columns[7].Name = "ReceiverAddress";
            dataGridTransfer.Columns[8].Name = "ReceiverContact";
            dataGridTransfer.Columns[9].Name = "Status"; 

            dataGridTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // == LOAD TRANSACTIONS FROM SQL DATABASE INTO HASH TABLE ==
        private void LoadFromDatabase()
        {
            transferTable = new HashTable<Transfer>();

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CashTransferTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Transfer transfer = new Transfer
                    {
                        TransferID = reader.GetInt32(0),
                        TransferDate = reader.GetDateTime(1),
                        Amount = reader.GetInt32(2), 
                        TransferType = reader.GetString(3),
                        TransferPurpose = reader.GetString(4),
                        SenderID = reader.GetInt32(5),
                        ReceiverName = reader.GetString(6),
                        ReceiverAddress = reader.GetString(7),
                        ReceiverContact = reader.GetString(8),
                        Status = reader.GetString(9)
                    };

                    transferTable.Insert(transfer.TransferID, transfer);
                }

            }
        }

        // == LOAD TRANSACTIONS INTO DATA GRID VIEW ==
        private void LoadTransactionData()
        {
            if (dataGridTransfer.Columns.Count == 0)
            {
                InitializeDataGridView();  
            }

            dataGridTransfer.Rows.Clear();  

            foreach (Transfer transaction in transferTable.GetAll())
            {
                dataGridTransfer.Rows.Add(
                    transaction.TransferID,
                    transaction.TransferDate.ToShortDateString(),
                    transaction.Amount,
                    transaction.TransferType,  
                    transaction.TransferPurpose,  
                    transaction.SenderID,
                    transaction.ReceiverName,
                    transaction.ReceiverAddress,
                    transaction.ReceiverContact,
                    transaction.Status
                );
            }
        }


        // == SAVE BUTTON FUNCTIONALITY ==//
        private void saveButton_Click(object sender, EventArgs e)
        {

        }


  

        // == EDIT BUTTON == // 
        private void editButton_Click(object sender, EventArgs e)
        {

        }


        // == DELETE BUTTON ==
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }



        private void ResetFields()
        {
            selectedTransferID = -1;
            Amount.Clear();
            TransactionType.SelectedIndex = -1;
            Description.Clear();
            senderName.Text = "";
            senderID.Clear();
            transferDate.Value = DateTime.Now;
            receiverName.Clear();
            receiverContact.Clear();
            receiverAddress.Clear();
            TransactionStatus.SelectedIndex = -1;
        }


        private void backBtn_Click(object sender, EventArgs e)
        {

        }

    }

        // Transfer Class
    public class Transfer
    {
        public int TransferID { get; set; }
        public DateTime TransferDate { get; set; }
        public decimal Amount { get; set; }
        public string? TransferType { get; set; }
        public string? TransferPurpose { get; set; }
        public int SenderID { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverAddress { get; set; }
        public string? ReceiverContact { get; set; }
        public string? Status { get; set; }
    }
    
}
