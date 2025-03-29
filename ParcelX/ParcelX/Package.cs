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
            //InitializeSearchFeature(); // Setup search features
            InitializeDataGridView(); // Ensure columns exist
            //LoadFromDatabase(); // Load transactions from DB
            //LoadPackageData(); // Display transactions in DataGridView

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

            //LoadFromDatabase(); 
            //LoadPackageData();  
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
