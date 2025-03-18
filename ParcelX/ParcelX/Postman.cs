using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PostalCW.DataStructures;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PostalCW
{
    public partial class Postman : Form
    {
        private HashTable<Officer> officerTable = new HashTable<Officer>();
        private int selectedOfficerID = -1;
        public string connectionString = @"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Postman()
        {
            InitializeComponent();
            InitializeDataGridView(); // Setup DataGridView  
            LoadFromDatabase(); // Load data from SQL into Hash Table
            LoadOfficerData(); // Display data  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            ApplyRoundedEdges(this, 50);
            ApplyRoundedEdges(panel1, 30);
            ApplyRoundedEdges(panel2, 30);
            ApplyRoundedEdges(panel3, 30);
            ApplyRoundedEdges(panel4, 30);
            ApplyRoundedEdges(panel7, 50);
            ApplyRoundedEdges(searchPanel, 30);

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



        // == SETUP DATA GRID VIEW COLUMNS ==
        private void InitializeDataGridView()
        {
            postmanDataGridView.Columns.Clear();
            postmanDataGridView.ColumnCount = 6;

            postmanDataGridView.Columns[0].Name = "OfficerID";
            postmanDataGridView.Columns[1].Name = "OfficerName";
            postmanDataGridView.Columns[2].Name = "OfficerAddress";
            postmanDataGridView.Columns[3].Name = "OfficerContact";
            postmanDataGridView.Columns[4].Name = "HireDate";
            postmanDataGridView.Columns[5].Name = "Employment";

            postmanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // == LOAD OFFICERS FROM SQL DATABASE INTO HASH TABLE ==
        private void LoadFromDatabase()
        {
            officerTable = new HashTable<Officer>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT OfficerID, OfficerName, OfficerAddress, OfficerContact, HireDate, Employment FROM PostmanTbl", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Officer officer = new Officer
                    {
                        OfficerID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        OfficerName = reader.IsDBNull(1) ? "N/A" : reader.GetString(1),
                        OfficerAddress = reader.IsDBNull(2) ? "N/A" : reader.GetString(2),
                        OfficerContact = reader.IsDBNull(3) ? "N/A" : reader.GetString(3),
                        HireDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        Employment = reader.IsDBNull(5) ? "N/A" : reader.GetString(5)
                    };

                    officerTable.Insert(officer.OfficerID, officer);
                }
            }
        }



        // == LOAD OFFICERS INTO DATA GRID VIEW ==
        private void LoadOfficerData()
        {
            postmanDataGridView.Rows.Clear();

            foreach (Officer officer in officerTable.GetAll()) // Fetch from hash table
            {
                postmanDataGridView.Rows.Add(officer.OfficerID, officer.OfficerName, officer.OfficerAddress,
                                             officer.OfficerContact,
                                             officer.HireDate.ToShortDateString(), officer.Employment);
            }
        }

        // == INSERT OFFICER INTO DATABASE ==
        private int InsertIntoDatabase(Officer officer)
        {
            int newOfficerID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PostmanTbl (OfficerName, OfficerAddress, OfficerContact, HireDate, Employment) " +
                    "OUTPUT INSERTED.OfficerID " +
                    "VALUES (@OfficerName, @OfficerAddress, @OfficerContact, @HireDate, @Employment)", con);

                cmd.Parameters.AddWithValue("@OfficerName", officer.OfficerName);
                cmd.Parameters.AddWithValue("@OfficerAddress", officer.OfficerAddress);
                cmd.Parameters.AddWithValue("@OfficerContact", officer.OfficerContact);
                cmd.Parameters.AddWithValue("@HireDate", officer.HireDate);
                cmd.Parameters.AddWithValue("@Employment", officer.Employment);

                newOfficerID = (int)cmd.ExecuteScalar();
            }

            return newOfficerID;
        }

        // == UPDATE OFFICER IN DATABASE ==
        private void UpdateDatabase(Officer officer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE PostmanTbl SET OfficerName=@OfficerName, OfficerAddress=@OfficerAddress, " +
                    "OfficerContact=@OfficerContact, HireDate=@HireDate, Employment=@Employment " +
                    "WHERE OfficerID=@OfficerID", con);

                cmd.Parameters.AddWithValue("@OfficerID", officer.OfficerID);
                cmd.Parameters.AddWithValue("@OfficerName", officer.OfficerName);
                cmd.Parameters.AddWithValue("@OfficerAddress", officer.OfficerAddress);
                cmd.Parameters.AddWithValue("@OfficerContact", officer.OfficerContact);
                cmd.Parameters.AddWithValue("@HireDate", officer.HireDate);
                cmd.Parameters.AddWithValue("@Employment", officer.Employment);

                cmd.ExecuteNonQuery();
            }
        }

        // == DELETE OFFICER FROM DATABASE ==
        private void DeleteFromDatabase(int officerID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PostmanTbl WHERE OfficerID = @OfficerID", con);
                cmd.Parameters.AddWithValue("@OfficerID", officerID);
                cmd.ExecuteNonQuery();
            }
        }



        // == SAVE BUTTON ==  
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OName.Text) ||
                string.IsNullOrWhiteSpace(OAddress.Text) ||
                string.IsNullOrWhiteSpace(OContact.Text) ||
                OEmploymentType.SelectedItem == null)
            {
                MessageBox.Show("Incomplete Data");
                return;
            }

            Officer newOfficer = new Officer
            {
                OfficerID = selectedOfficerID,
                OfficerName = OName.Text,
                OfficerAddress = OAddress.Text,
                OfficerContact = OContact.Text,
                HireDate = OHireDate.Value,
                Employment = OEmploymentType.SelectedItem.ToString()
            };

            if (selectedOfficerID == -1)
            {
                newOfficer.OfficerID = InsertIntoDatabase(newOfficer);
                officerTable.Insert(newOfficer.OfficerID, newOfficer);
            }
            else
            {
                UpdateDatabase(newOfficer);
                officerTable.Remove(selectedOfficerID);
                officerTable.Insert(newOfficer.OfficerID, newOfficer);
            }

            MessageBox.Show("Officer saved successfully!");
            LoadOfficerData(); // Refresh  
            ResetFields();
        }


        // == RESET FIELDS ==
        private void ResetFields()
        {
            selectedOfficerID = -1;
            OName.Clear();
            OAddress.Clear();
            OContact.Clear();
            OHireDate.Value = DateTime.Now;
            OEmploymentType.SelectedIndex = -1;
        }



        // == EDIT BUTTON ==
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (postmanDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an officer to edit.");
                return;
            }

            selectedOfficerID = Convert.ToInt32(postmanDataGridView.SelectedRows[0].Cells["OfficerID"].Value);
            Officer selectedOfficer = officerTable.Get(selectedOfficerID);

            if (selectedOfficer != null)
            {
                OName.Text = selectedOfficer.OfficerName;
                OAddress.Text = selectedOfficer.OfficerAddress;
                OContact.Text = selectedOfficer.OfficerContact;
                OHireDate.Value = selectedOfficer.HireDate;
                OEmploymentType.SelectedItem = selectedOfficer.Employment;
            }
        }


        // == DELETE BUTTON ==
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (postmanDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an officer to delete.");
                return;
            }

            int officerID = Convert.ToInt32(postmanDataGridView.SelectedRows[0].Cells["OfficerID"].Value);
            DeleteFromDatabase(officerID);
            officerTable.Remove(officerID);

            MessageBox.Show("Officer Deleted Successfully!");
            LoadOfficerData();

        }



        //SEARCH FUNCTIONALITY
        private void SearchIcon_Click(object sender, EventArgs e)
        {
            string searchQuery = SearchTextbox.Text.Trim().ToLower(); // Convert input to lowercase for case-insensitivity

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter an Officer ID or Name to search.");
                return;
            }

            List<Officer> matchingOfficers = new List<Officer>(); // List to store all matching officers

            // Try searching by Officer ID (if numeric)
            if (int.TryParse(searchQuery, out int officerID))
            {
                Officer foundOfficer = officerTable.Get(officerID);
                if (foundOfficer != null)
                {
                    matchingOfficers.Add(foundOfficer);
                }
            }
            else
            {
                // Search for Officer Name (Partial match)
                foreach (Officer officer in officerTable.GetAll())
                {
                    if (officer.OfficerName.ToLower().Contains(searchQuery)) // Partial case-insensitive match
                    {
                        matchingOfficers.Add(officer);
                    }
                }
            }

            if (matchingOfficers.Count > 0)
            {
                // Deselect all previous selections
                postmanDataGridView.ClearSelection();

                // Select all matching rows in DataGridView
                foreach (DataGridViewRow row in postmanDataGridView.Rows)
                {
                    int rowOfficerID = Convert.ToInt32(row.Cells["OfficerID"].Value);
                    if (matchingOfficers.Any(o => o.OfficerID == rowOfficerID)) // Check if row matches any found officer
                    {
                        row.Selected = true;
                    }
                }

                MessageBox.Show($"Found {matchingOfficers.Count} matching result(s).");
            }
            else
            {
                MessageBox.Show("No matching officer found.");
            }
        }


        private void CrossIcon_Click_1(object sender, EventArgs e)
        {
            // Clear the search box
            SearchTextbox.Text = "";

            // Deselect any selected row in DataGridView
            postmanDataGridView.ClearSelection();

            // Reset scrolling to top
            if (postmanDataGridView.Rows.Count > 0)
            {
                postmanDataGridView.FirstDisplayedScrollingRowIndex = 0;
            }

        }

        //BACK BUTTON FUNCTIONALITY
        private void backBtn_Click(object sender, EventArgs e)
        {

        }
    }

    // Officer Class 
    public class Officer
    {
        public int OfficerID { get; set; }
        public string OfficerName { get; set; }
        public string OfficerAddress { get; set; }
        public string OfficerContact { get; set; }
        public DateTime HireDate { get; set; }
        public string Employment { get; set; }
    }

}
