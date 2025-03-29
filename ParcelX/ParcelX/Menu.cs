using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PostalCW
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.Load += new EventHandler(Menu_Load);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ApplyRoundedEdges(this, 60);
            ApplyRoundedEdges(panel2, 60);

            ApplyRoundedEdges(PackageIcon, 80);
            ApplyRoundedEdges(ClientIcon, 80);
            ApplyRoundedEdges(TransferIcon, 80);
            ApplyRoundedEdges(PostmanIcon, 80);
            ApplyRoundedEdges(LogoutIcon, 75);

            // Attach event handlers for click events
            PackageIcon.Click += PackagePic_Click;
            ClientIcon.Click += ClientPic_Click;
            TransferIcon.Click += TransferPic_Click;
            PostmanIcon.Click += PostmanPic_Click;
            LogoutIcon.Click += LogoutPic_Click;
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

        //  Package Form
        private void PackagePic_Click(object sender, EventArgs e)
        {
            Package packageForm = new Package();
            packageForm.Show();
        }

        //  Clients Form
        private void ClientPic_Click(object sender, EventArgs e)
        {
            Clients clientForm = new Clients();
            clientForm.Show();
        }

        //  Cash Transfer Form
        private void TransferPic_Click(object sender, EventArgs e)
        {
            CashTransfer transferForm = new CashTransfer();
            transferForm.Show();
        }

        //  Postman Form
        private void PostmanPic_Click(object sender, EventArgs e)
        {
            Postman postmanForm = new Postman();
            postmanForm.Show();
        }

        private void LogoutPic_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Program.connectionString))
                {
                    con.Open();

                    // Delete all data from PostmanTbl
                    SqlCommand cmd = new SqlCommand("DELETE FROM PostmanTbl", con);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("All data has been removed. Logging out...", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // Close application
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
