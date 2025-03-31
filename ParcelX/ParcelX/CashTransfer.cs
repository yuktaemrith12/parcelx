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





        // == INSERT TRANSACTION INTO DATABASE == //
        private int InsertIntoDatabase(Transfer transfer)
        {
            int newTransferID;

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO CashTransferTbl (TransferDate, Amount, TransferType, TransferPurpose, SenderID, ReceiverName, ReceiverAddress, ReceiverContact, Status) " +
                    "OUTPUT INSERTED.TransferID VALUES (@TransferDate, @Amount, @TransferType, @TransferPurpose, @SenderID, @ReceiverName, @ReceiverAddress, @ReceiverContact, @Status)", con);

                cmd.Parameters.AddWithValue("@TransferDate", transfer.TransferDate);
                cmd.Parameters.AddWithValue("@Amount", transfer.Amount);
                cmd.Parameters.AddWithValue("@TransferType", transfer.TransferType);
                cmd.Parameters.AddWithValue("@TransferPurpose", transfer.TransferPurpose);
                cmd.Parameters.AddWithValue("@SenderID", transfer.SenderID);
                cmd.Parameters.AddWithValue("@ReceiverName", transfer.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverAddress", transfer.ReceiverAddress);
                cmd.Parameters.AddWithValue("@ReceiverContact", transfer.ReceiverContact);
                cmd.Parameters.AddWithValue("@Status", transfer.Status);

                newTransferID = (int)cmd.ExecuteScalar();
            }

            return newTransferID;
        }

        // == SAVE BUTTON FUNCTIONALITY ==//
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Amount.Text) ||
                string.IsNullOrWhiteSpace(senderID.Text) ||
                string.IsNullOrWhiteSpace(receiverName.Text) ||
                string.IsNullOrWhiteSpace(receiverAddress.Text))
            {
                MessageBox.Show("Incomplete Data. Please fill all fields.");
                return;
            }

            Transfer newTransfer = new Transfer
            {
                TransferID = selectedTransferID,
                TransferDate = transferDate.Value,
                Amount = Convert.ToInt32(Amount.Text), 
                TransferType = TransactionType.Text,
                TransferPurpose = Description.Text,
                SenderID = Convert.ToInt32(senderID.Text),
                ReceiverName = receiverName.Text,
                ReceiverAddress = receiverAddress.Text,
                ReceiverContact = receiverContact.Text,
                Status = TransactionStatus.Text
            };

            try
            {
                if (selectedTransferID == -1) // New transaction
                {
                    newTransfer.TransferID = InsertIntoDatabase(newTransfer);
                    transferTable.Insert(newTransfer.TransferID, newTransfer);
                }
                else // Editing an existing transaction
                {
                    UpdateDatabase(newTransfer);
                    transferTable.Remove(selectedTransferID);
                    transferTable.Insert(newTransfer.TransferID, newTransfer);
                }

                MessageBox.Show("Transaction saved successfully!");
                LoadTransactionData(); // Refresh DataGridView
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // == UPDATE TRANSACTION IN DATABASE == //
        private void UpdateDatabase(Transfer transfer)
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE CashTransferTbl SET TransferDate=@TransferDate, Amount=@Amount, TransferType=@TransferType, " +
                    "TransferPurpose=@TransferPurpose, SenderID=@SenderID, ReceiverName=@ReceiverName, " +
                    "ReceiverAddress=@ReceiverAddress, ReceiverContact=@ReceiverContact, Status=@Status " +
                    "WHERE TransferID=@TransferID", con);

                cmd.Parameters.AddWithValue("@TransferID", transfer.TransferID);
                cmd.Parameters.AddWithValue("@TransferDate", transfer.TransferDate);
                cmd.Parameters.AddWithValue("@Amount", transfer.Amount);
                cmd.Parameters.AddWithValue("@TransferType", transfer.TransferType);
                cmd.Parameters.AddWithValue("@TransferPurpose", transfer.TransferPurpose);
                cmd.Parameters.AddWithValue("@SenderID", transfer.SenderID);
                cmd.Parameters.AddWithValue("@ReceiverName", transfer.ReceiverName);
                cmd.Parameters.AddWithValue("@ReceiverAddress", transfer.ReceiverAddress);
                cmd.Parameters.AddWithValue("@ReceiverContact", transfer.ReceiverContact);
                cmd.Parameters.AddWithValue("@Status", transfer.Status);

                cmd.ExecuteNonQuery();
            }
        }

        // == EDIT BUTTON == // 
        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridTransfer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to edit.");
                return;
            }

            // Get selected row data
            selectedTransferID = Convert.ToInt32(dataGridTransfer.SelectedRows[0].Cells["TransferID"].Value);

            Amount.Text = dataGridTransfer.SelectedRows[0].Cells["Amount"].Value.ToString();
            TransactionType.Text = dataGridTransfer.SelectedRows[0].Cells["TransferType"].Value.ToString();  
            Description.Text = dataGridTransfer.SelectedRows[0].Cells["TransferPurpose"].Value.ToString();  
            senderID.Text = dataGridTransfer.SelectedRows[0].Cells["SenderID"].Value.ToString();
            transferDate.Value = Convert.ToDateTime(dataGridTransfer.SelectedRows[0].Cells["TransferDate"].Value);
            receiverName.Text = dataGridTransfer.SelectedRows[0].Cells["ReceiverName"].Value.ToString();
            receiverContact.Text = dataGridTransfer.SelectedRows[0].Cells["ReceiverContact"].Value.ToString();
            receiverAddress.Text = dataGridTransfer.SelectedRows[0].Cells["ReceiverAddress"].Value.ToString();
            TransactionStatus.Text = dataGridTransfer.SelectedRows[0].Cells["Status"].Value.ToString();
        }


        // == DELETE BUTTON ==
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridTransfer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete.");
                return;
            }

            int transferID = Convert.ToInt32(dataGridTransfer.SelectedRows[0].Cells["TransferID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(Con.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CashTransferTbl WHERE TransferID = @TransferID", con);
                    cmd.Parameters.AddWithValue("@TransferID", transferID);
                    cmd.ExecuteNonQuery();
                }

                transferTable.Remove(transferID); // Remove from HashTable

                MessageBox.Show("Transaction Deleted Successfully!");
                LoadTransactionData(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            this.Hide();  // Hide the current form
            Menu menuForm = new Menu();
            menuForm.Show();  // Show the Menu form
        }

    }

    // Transfer Class
    public class Transfer
    {
        public int TransferID { get; set; }
        public DateTime TransferDate { get; set; }
        public decimal Amount { get; set; }
        public string TransferType { get; set; }
        public string TransferPurpose { get; set; }
        public int SenderID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverContact { get; set; }
        public string Status { get; set; }
    }
}
