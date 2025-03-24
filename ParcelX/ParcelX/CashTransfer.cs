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


        public CashTransfer()
        {
            InitializeComponent();
            //InitializeSearchFeature(); // Set up search feature for Sender Name
            //LoadFromDatabase(); // Load transactions from DB to hash table
            //LoadTransactionData(); // Display transactions in DataGridView
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
            //LoadFromDatabase();
            //LoadTransactionData();
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
        public string TransferType { get; set; }
        public string TransferPurpose { get; set; }
        public int SenderID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverContact { get; set; }
        public string Status { get; set; }
    }
    
}
