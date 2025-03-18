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
            //LoadFromDatabase(); // Load data from SQL into Hash Table
            //LoadOfficerData(); // Display data  

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




        // == DELETE OFFICER FROM DATABASE ==
        private void DeleteFromDatabase(int officerID)
        {

        }

        // == SAVE BUTTON ==  
        private void saveButton_Click(object sender, EventArgs e)
        {

        }


        // == RESET FIELDS ==
        private void ResetFields()
        {

        }



        // == EDIT BUTTON ==
        private void EditButton_Click(object sender, EventArgs e)
        {

        }


        // == DELETE BUTTON ==
        private void deleteButton_Click(object sender, EventArgs e)
        {


        }



        //SEARCH FUNCTIONALITY
        private void SearchIcon_Click(object sender, EventArgs e)
        {

        }


        private void CrossIcon_Click_1(object sender, EventArgs e)
        {


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
