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
    public partial class Package : Form
    {
        // Database connection
        private SqlConnection Con = new SqlConnection(@"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        // Hash Table 
        private HashTable<PackageData> packageTable = new HashTable<PackageData>();
        private int selectedPackageID = -1; 


        public Package()
        {
            InitializeComponent();
            InitializeSearchFeature(); // Setup search features
            InitializeDataGridView(); // Ensure columns exist
            LoadFromDatabase(); // Load transactions from DB
            LoadPackageData(); // Display transactions in DataGridView

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(Package_Load);
        }

        private void Package_Load(object sender, EventArgs e)
        {
            ApplyRoundedEdges(this, 50);
            ApplyRoundedEdges(panel1, 30);
            ApplyRoundedEdges(panel2, 30);
            ApplyRoundedEdges(panel3, 30);
            ApplyRoundedEdges(panel4, 30);
            ApplyRoundedEdges(panel5, 30);
            ApplyRoundedEdges(panel6, 30);
            ApplyRoundedEdges(panel7, 30);
            ApplyRoundedEdges(panel8, 30);

            LoadFromDatabase(); 
            LoadPackageData();  
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




        // == DATAGRID ==
        private void InitializeDataGridView()
        {
            dataGridViewPackage.Columns.Clear(); 

            dataGridViewPackage.ColumnCount = 11; 

            dataGridViewPackage.Columns[0].Name = "PackageID";
            dataGridViewPackage.Columns[1].Name = "Dimension";
            dataGridViewPackage.Columns[2].Name = "Weight";
            dataGridViewPackage.Columns[3].Name = "Priority";
            dataGridViewPackage.Columns[4].Name = "Content";
            dataGridViewPackage.Columns[5].Name = "SenderID";         
            dataGridViewPackage.Columns[6].Name = "DropDate";        
            dataGridViewPackage.Columns[7].Name = "ReceiverName";
            dataGridViewPackage.Columns[8].Name = "ReceiverContact";
            dataGridViewPackage.Columns[9].Name = "ReceiverAddress";
            dataGridViewPackage.Columns[10].Name = "OfficerID";       

            dataGridViewPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void InitializeSearchFeature()
        {
            // === SENDER SEARCH FUNCTIONALITY === //
            SenderName.DropDownStyle = ComboBoxStyle.DropDown; 
            SenderName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SenderName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection senderNamesCollection = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientID, ClientName FROM ClientsTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                // Load names into ComboBox & AutoComplete
                while (reader.Read())
                {
                    string? clientName = reader["ClientName"].ToString();
                    int clientID = Convert.ToInt32(reader["ClientID"]);

                    senderNamesCollection.Add(clientName);
                    SenderName.Items.Add(clientName); // Add names to ComboBox
                }
            }

            SenderName.AutoCompleteCustomSource = senderNamesCollection;

            // Update Sender ID on selection change
            SenderName.SelectedIndexChanged += (s, e) => UpdateSenderID();
            SenderName.TextChanged += (s, e) => UpdateSenderID();


            // === OFFICER SEARCH FUNCTIONALITY ===
            OfficerName.DropDownStyle = ComboBoxStyle.DropDown;
            OfficerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OfficerName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection officerNamesCollection = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT OfficerID, OfficerName FROM PostmanTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                // Load officer names into ComboBox & AutoComplete
                while (reader.Read())
                {
                    string? officerNameValue = reader["OfficerName"].ToString();
                    int officerIDValue = Convert.ToInt32(reader["OfficerID"]);

                    officerNamesCollection.Add(officerNameValue);
                    OfficerName.Items.Add(officerNameValue); // Add names to ComboBox
                }
            }

            OfficerName.AutoCompleteCustomSource = officerNamesCollection;

            // Update Officer ID on selection change
            OfficerName.SelectedIndexChanged += (s, e) => UpdateOfficerID();
            OfficerName.TextChanged += (s, e) => UpdateOfficerID();
        }

        // Helper method to update Sender ID when a name is selected
        private void UpdateSenderID()
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ClientID FROM ClientsTbl WHERE ClientName = @ClientName", con);
                cmd.Parameters.AddWithValue("@ClientName", SenderName.Text);

                object result = cmd.ExecuteScalar();
                SenderID.Text = (result != null) ? result.ToString() : "";
            }
        }

        // Helper method to update Officer ID when a name is selected
        private void UpdateOfficerID()
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT OfficerID FROM PostmanTbl WHERE OfficerName = @OfficerName", con);
                cmd.Parameters.AddWithValue("@OfficerName", OfficerName.Text);

                object result = cmd.ExecuteScalar();
                OfficerID.Text = (result != null) ? result.ToString() : "";
            }
        }

        // == LOAD PACKAGES FROM SQL DATABASE INTO HASH TABLE ==
        private void LoadFromDatabase()
        {
            packageTable = new HashTable<PackageData>(); // Initialize HashTable

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PackageTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PackageData package = new PackageData
                    {
                        PackageID = reader.GetInt32(0),
                        Dimension = reader.GetString(1),
                        Weight = reader.GetInt32(2),
                        Priority = reader.GetString(3),
                        Content = reader.GetString(4),
                        SenderID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),  
                        DropDate = reader.GetDateTime(6),
                        ReceiverName = reader.GetString(7),
                        ReceiverContact = reader.GetString(8),
                        ReceiverAddress = reader.GetString(9),
                        OfficerID = reader.IsDBNull(10) ? (int?)null : reader.GetInt32(10)  
                    };

                    packageTable.Insert(package.PackageID, package);
                }
            }
        }

        // == LOAD PACKAGES INTO DATA GRID VIEW ==
        private void LoadPackageData()
        {
            if (dataGridViewPackage.Columns.Count == 0)
            {
                InitializeDataGridView();  
            }

            dataGridViewPackage.Rows.Clear();  

            foreach (PackageData package in packageTable.GetAll())
            {
                dataGridViewPackage.Rows.Add(
                    package.PackageID,                      
                    package.Dimension,                     
                    package.Weight,                        
                    package.Priority,                      
                    package.Content,                        
                    package.SenderID.HasValue ? package.SenderID.Value.ToString() : "N/A", 
                    package.DropDate.ToShortDateString(),   
                    package.ReceiverName,                   
                    package.ReceiverContact,                
                    package.ReceiverAddress,               
                    package.OfficerID.HasValue ? package.OfficerID.Value.ToString() : "N/A"  
                );
            }
        }

        // == INSERT TRANSACTION INTO DATABASE ==
        private int InsertIntoDatabase(PackageData package)
        {
            int newPackageID;

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PackageTbl (Dimension, Weight, Priority, Content, SenderID, DropDate, ReceiverName, ReceiverContact, ReceiverAddress, OfficerID) " +
                    "OUTPUT INSERTED.PackageID VALUES (@Dimension, @Weight, @Priority, @Content, @SenderID, @DropDate, @ReceiverName, @ReceiverContact, @ReceiverAddress, @OfficerID)", con);

                cmd.Parameters.AddWithValue("@Dimension", package.Dimension);
                cmd.Parameters.AddWithValue("@Weight", package.Weight);
                cmd.Parameters.AddWithValue("@Priority", package.Priority);
                cmd.Parameters.AddWithValue("@Content", package.Content);
                cmd.Parameters.AddWithValue("@SenderID", package.SenderID);
                cmd.Parameters.AddWithValue("@DropDate", package.DropDate);
                cmd.Parameters.AddWithValue("@ReceiverName", package.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverContact", package.ReceiverContact);
                cmd.Parameters.AddWithValue("@ReceiverAddress", package.ReceiverAddress);
                cmd.Parameters.AddWithValue("@OfficerID", package.OfficerID);

                newPackageID = (int)cmd.ExecuteScalar();
            }

            return newPackageID;
        }

        // == UPDATE PACKAGE IN DATABASE ==
        private void UpdateDatabase(PackageData package)
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE PackageTbl SET Dimension=@Dimension, Weight=@Weight, Priority=@Priority, " +
                    "Content=@Content, SenderID=@SenderID, DropDate=@DropDate, ReceiverName=@ReceiverName, " +
                    "ReceiverAddress=@ReceiverAddress, ReceiverContact=@ReceiverContact, OfficerID=@OfficerID " +
                    "WHERE PackageID=@PackageID", con);

                cmd.Parameters.AddWithValue("@PackageID", package.PackageID);
                cmd.Parameters.AddWithValue("@Dimension", package.Dimension);
                cmd.Parameters.AddWithValue("@Weight", package.Weight);
                cmd.Parameters.AddWithValue("@Priority", package.Priority);
                cmd.Parameters.AddWithValue("@Content", package.Content);
                cmd.Parameters.AddWithValue("@SenderID", package.SenderID);
                cmd.Parameters.AddWithValue("@DropDate", package.DropDate);
                cmd.Parameters.AddWithValue("@ReceiverName", package.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverAddress", package.ReceiverAddress);
                cmd.Parameters.AddWithValue("@ReceiverContact", package.ReceiverContact);
                cmd.Parameters.AddWithValue("@OfficerID", package.OfficerID);

                cmd.ExecuteNonQuery();
            }
        }




        // == SAVE BUTTON FUNCTIONALITY ==
        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }



        // == EDIT BUTTON ==
        private void editButton_Click(object sender, EventArgs e)
        {
            
        }



        // == DELETE BUTTON==
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }



        private void backBtn_Click(object sender, EventArgs e)
        {

        }

    }

        public class PackageData
    {
        public int PackageID { get; set; }
        public string? Dimension { get; set; }
        public int Weight { get; set; }
        public string? Priority { get; set; }
        public string? Content { get; set; }
        public int? SenderID { get; set; }   
        public DateTime DropDate { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverContact { get; set; }
        public string? ReceiverAddress { get; set; }
        public int? OfficerID { get; set; }  
    }



}
