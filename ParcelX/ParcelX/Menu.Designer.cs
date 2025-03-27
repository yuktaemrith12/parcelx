namespace PostalCW
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            PackageIcon = new Panel();
            textBox2 = new TextBox();
            PackagePic = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            ClientIcon = new Panel();
            textBox3 = new TextBox();
            ClientPic = new PictureBox();
            TransferIcon = new Panel();
            textBox4 = new TextBox();
            TransferPic = new PictureBox();
            PostmanIcon = new Panel();
            textBox5 = new TextBox();
            PostmanPic = new PictureBox();
            LogoutIcon = new Panel();
            LogoutPic = new PictureBox();
            PackageIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PackagePic).BeginInit();
            panel2.SuspendLayout();
            ClientIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientPic).BeginInit();
            TransferIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransferPic).BeginInit();
            PostmanIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PostmanPic).BeginInit();
            LogoutIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPic).BeginInit();
            SuspendLayout();
            // 
            // PackageIcon
            // 
            PackageIcon.BackColor = Color.Goldenrod;
            PackageIcon.Controls.Add(textBox2);
            PackageIcon.Controls.Add(PackagePic);
            PackageIcon.Location = new Point(170, 220);
            PackageIcon.Name = "PackageIcon";
            PackageIcon.Size = new Size(278, 281);
            PackageIcon.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Goldenrod;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(64, 200);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(161, 47);
            textBox2.TabIndex = 6;
            textBox2.Text = "Package";
            // 
            // PackagePic
            // 
            PackagePic.Image = (Image)resources.GetObject("PackagePic.Image");
            PackagePic.Location = new Point(49, 29);
            PackagePic.Name = "PackagePic";
            PackagePic.Size = new Size(176, 165);
            PackagePic.SizeMode = PictureBoxSizeMode.Zoom;
            PackagePic.TabIndex = 0;
            PackagePic.TabStop = false;
            PackagePic.Click += PackagePic_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Wheat;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(376, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 84);
            textBox1.TabIndex = 3;
            textBox1.Text = "MAIN MENU";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(28, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 118);
            panel2.TabIndex = 4;
            // 
            // ClientIcon
            // 
            ClientIcon.BackColor = Color.Goldenrod;
            ClientIcon.Controls.Add(textBox3);
            ClientIcon.Controls.Add(ClientPic);
            ClientIcon.Location = new Point(651, 220);
            ClientIcon.Name = "ClientIcon";
            ClientIcon.Size = new Size(278, 281);
            ClientIcon.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Goldenrod;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(76, 200);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(161, 47);
            textBox3.TabIndex = 1;
            textBox3.Text = "Clients";
            // 
            // ClientPic
            // 
            ClientPic.Image = (Image)resources.GetObject("ClientPic.Image");
            ClientPic.Location = new Point(61, 29);
            ClientPic.Name = "ClientPic";
            ClientPic.Size = new Size(176, 165);
            ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            ClientPic.TabIndex = 0;
            ClientPic.TabStop = false;
            ClientPic.Click += ClientPic_Click;
            // 
            // TransferIcon
            // 
            TransferIcon.BackColor = Color.Goldenrod;
            TransferIcon.Controls.Add(textBox4);
            TransferIcon.Controls.Add(TransferPic);
            TransferIcon.Location = new Point(170, 564);
            TransferIcon.Name = "TransferIcon";
            TransferIcon.Size = new Size(278, 281);
            TransferIcon.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Goldenrod;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(9, 199);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(266, 47);
            textBox4.TabIndex = 1;
            textBox4.Text = "Cash Transfer";
            // 
            // TransferPic
            // 
            TransferPic.Image = (Image)resources.GetObject("TransferPic.Image");
            TransferPic.Location = new Point(49, 26);
            TransferPic.Name = "TransferPic";
            TransferPic.Size = new Size(176, 165);
            TransferPic.SizeMode = PictureBoxSizeMode.Zoom;
            TransferPic.TabIndex = 0;
            TransferPic.TabStop = false;
            TransferPic.Click += TransferPic_Click;
            // 
            // PostmanIcon
            // 
            PostmanIcon.BackColor = Color.Goldenrod;
            PostmanIcon.Controls.Add(textBox5);
            PostmanIcon.Controls.Add(PostmanPic);
            PostmanIcon.Location = new Point(651, 564);
            PostmanIcon.Name = "PostmanIcon";
            PostmanIcon.Size = new Size(278, 281);
            PostmanIcon.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Goldenrod;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(76, 199);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(161, 47);
            textBox5.TabIndex = 1;
            textBox5.Text = "Postman";
            // 
            // PostmanPic
            // 
            PostmanPic.Image = (Image)resources.GetObject("PostmanPic.Image");
            PostmanPic.Location = new Point(61, 36);
            PostmanPic.Name = "PostmanPic";
            PostmanPic.Size = new Size(176, 165);
            PostmanPic.SizeMode = PictureBoxSizeMode.Zoom;
            PostmanPic.TabIndex = 0;
            PostmanPic.TabStop = false;
            PostmanPic.Click += PostmanPic_Click;
            // 
            // LogoutIcon
            // 
            LogoutIcon.BackColor = Color.Goldenrod;
            LogoutIcon.Controls.Add(LogoutPic);
            LogoutIcon.Location = new Point(1058, 763);
            LogoutIcon.Name = "LogoutIcon";
            LogoutIcon.Size = new Size(114, 112);
            LogoutIcon.TabIndex = 4;
            // 
            // LogoutPic
            // 
            LogoutPic.Image = (Image)resources.GetObject("LogoutPic.Image");
            LogoutPic.Location = new Point(24, 23);
            LogoutPic.Name = "LogoutPic";
            LogoutPic.Size = new Size(67, 61);
            LogoutPic.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutPic.TabIndex = 0;
            LogoutPic.TabStop = false;
            LogoutPic.Click += LogoutPic_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1200, 900);
            Controls.Add(LogoutIcon);
            Controls.Add(PostmanIcon);
            Controls.Add(TransferIcon);
            Controls.Add(ClientIcon);
            Controls.Add(panel2);
            Controls.Add(PackageIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            PackageIcon.ResumeLayout(false);
            PackageIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PackagePic).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ClientIcon.ResumeLayout(false);
            ClientIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientPic).EndInit();
            TransferIcon.ResumeLayout(false);
            TransferIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransferPic).EndInit();
            PostmanIcon.ResumeLayout(false);
            PostmanIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PostmanPic).EndInit();
            LogoutIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoutPic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PackageIcon;
        private PictureBox PackagePic;
        private TextBox textBox1;
        private Panel panel2;
        private Panel ClientIcon;
        private TextBox textBox3;
        private PictureBox ClientPic;
        private Panel TransferIcon;
        private TextBox textBox4;
        private PictureBox TransferPic;
        private Panel PostmanIcon;
        private TextBox textBox5;
        private PictureBox PostmanPic;
        private Panel LogoutIcon;
        private PictureBox LogoutPic;
        private TextBox textBox2;
    }
}