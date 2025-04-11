using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PostalCW
{
    public partial class FilePath : Form
    {
        public FilePath()
        {
            InitializeComponent();
        }

        private void FilePath_Load(object sender, EventArgs e)
        {
            ApplyRoundedEdges(this, 50);
            // Add more rounded edges for panels if needed here
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

        // == BROWSE BUTTON ==
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Postman Data File";
            dialog.Filter = "Text files (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textfilePath.Text = dialog.FileName;
            }
        }

        // == NEXT / INSERT BUTTON ==
        private void NextBtn_Click(object sender, EventArgs e)
        {
            string filePath = textfilePath.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Invalid file path. Please select a valid .txt file.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.dataFilePath = filePath;
            Program.LoadPostmanData();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // == SKIP BUTTON ==
        private void SkipBtn_Click(object sender, EventArgs e)
        {
            if (Program.DatabaseHasPostmanData())
            {
                this.DialogResult = DialogResult.Ignore;
                this.Close();
            }
            else
            {
                MessageBox.Show("The database is currently empty. Please insert a valid file path first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textfilePath_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation or placeholder handling
        }
    }
}
