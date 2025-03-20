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


        public Clients()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize columns 
            //LoadFromDatabase(); // Load clients into hash table from SQL
            //LoadClientData(); // Display clients 

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

       






        // == SAVE CLIENT == //
        private void SaveButton_Click(object sender, EventArgs e)
        {
   

        }


        // == EDIT CLIENT == //
        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        // == UPLOAD IMAGE == //
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // == DELETE CLIENT == //
        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }




        private void backBtn_Click(object sender, EventArgs e)
        {

        }

    }


}
