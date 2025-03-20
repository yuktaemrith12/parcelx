namespace PostalCW
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DeleteButton = new Button();
            SaveButton = new Button();
            EditButton = new Button();
            panel4 = new Panel();
            panel7 = new Panel();
            textBox4 = new TextBox();
            UploadButton = new Button();
            label8 = new Label();
            ClientIDpic = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            backBtn = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            ClientContact = new TextBox();
            label2 = new Label();
            ClientAddress = new TextBox();
            ClientName = new TextBox();
            clientTableLayout = new Panel();
            clientDataGridView = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            ClientEmail = new TextBox();
            ClientNID = new TextBox();
            label4 = new Label();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientIDpic).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            clientTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkGoldenrod;
            DeleteButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(69, 284);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(150, 50);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Goldenrod;
            SaveButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(69, 182);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(150, 50);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Goldenrod;
            EditButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(69, 81);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(150, 50);
            EditButton.TabIndex = 0;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(DeleteButton);
            panel4.Controls.Add(SaveButton);
            panel4.Controls.Add(EditButton);
            panel4.ForeColor = Color.DimGray;
            panel4.Location = new Point(1585, 829);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 427);
            panel4.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Cornsilk;
            panel7.Controls.Add(textBox4);
            panel7.Location = new Point(416, 17);
            panel7.Name = "panel7";
            panel7.Size = new Size(729, 63);
            panel7.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cornsilk;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(255, 13);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 38);
            textBox4.TabIndex = 0;
            textBox4.Text = "CLIENT DETAILS";
            // 
            // UploadButton
            // 
            UploadButton.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UploadButton.Location = new Point(1238, 365);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(112, 42);
            UploadButton.TabIndex = 14;
            UploadButton.Text = "Upload";
            UploadButton.UseVisualStyleBackColor = true;
            UploadButton.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1225, 111);
            label8.Name = "label8";
            label8.Size = new Size(125, 29);
            label8.TabIndex = 13;
            label8.Text = "ID Picture";
            // 
            // ClientIDpic
            // 
            ClientIDpic.BorderStyle = BorderStyle.FixedSingle;
            ClientIDpic.Location = new Point(1087, 143);
            ClientIDpic.Name = "ClientIDpic";
            ClientIDpic.Size = new Size(405, 216);
            ClientIDpic.TabIndex = 12;
            ClientIDpic.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1880, 180);
            panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1711, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(28, 38);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(103, 95);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 2;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.OldLace;
            label10.Location = new Point(661, 112);
            label10.Name = "label10";
            label10.Size = new Size(443, 36);
            label10.TabIndex = 1;
            label10.Text = "PARCEL X MANAGEMENT SYSTEM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(575, 22);
            label9.Name = "label9";
            label9.Size = new Size(611, 90);
            label9.TabIndex = 0;
            label9.Text = "Client Dashboard";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(586, 223);
            label5.Name = "label5";
            label5.Size = new Size(200, 29);
            label5.TabIndex = 8;
            label5.Text = "Current Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 310);
            label3.Name = "label3";
            label3.Size = new Size(199, 29);
            label3.TabIndex = 3;
            label3.Text = "Contact Number";
            // 
            // ClientContact
            // 
            ClientContact.Location = new Point(48, 349);
            ClientContact.Name = "ClientContact";
            ClientContact.Size = new Size(475, 31);
            ClientContact.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // ClientAddress
            // 
            ClientAddress.Location = new Point(585, 255);
            ClientAddress.Multiline = true;
            ClientAddress.Name = "ClientAddress";
            ClientAddress.Size = new Size(475, 125);
            ClientAddress.TabIndex = 2;
            // 
            // ClientName
            // 
            ClientName.Location = new Point(49, 153);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(474, 31);
            ClientName.TabIndex = 0;
            // 
            // clientTableLayout
            // 
            clientTableLayout.AutoSize = true;
            clientTableLayout.BackColor = Color.White;
            clientTableLayout.Controls.Add(clientDataGridView);
            clientTableLayout.Location = new Point(28, 205);
            clientTableLayout.Name = "clientTableLayout";
            clientTableLayout.Size = new Size(1833, 587);
            clientTableLayout.TabIndex = 7;
            // 
            // clientDataGridView
            // 
            clientDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientDataGridView.BackgroundColor = Color.White;
            clientDataGridView.BorderStyle = BorderStyle.None;
            clientDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Goldenrod;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.OldLace;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            clientDataGridView.GridColor = SystemColors.InactiveCaption;
            clientDataGridView.Location = new Point(19, 19);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Goldenrod;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            clientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            clientDataGridView.RowHeadersWidth = 62;
            clientDataGridView.Size = new Size(1785, 534);
            clientDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 121);
            label1.Name = "label1";
            label1.Size = new Size(202, 29);
            label1.TabIndex = 0;
            label1.Text = "Client Full Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(ClientEmail);
            panel3.Controls.Add(ClientNID);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(UploadButton);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(ClientIDpic);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ClientContact);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ClientAddress);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(ClientName);
            panel3.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(28, 829);
            panel3.Name = "panel3";
            panel3.Size = new Size(1530, 427);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(584, 121);
            label6.Name = "label6";
            label6.Size = new Size(77, 29);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // ClientEmail
            // 
            ClientEmail.Location = new Point(586, 153);
            ClientEmail.Name = "ClientEmail";
            ClientEmail.Size = new Size(474, 31);
            ClientEmail.TabIndex = 18;
            // 
            // ClientNID
            // 
            ClientNID.Location = new Point(52, 255);
            ClientNID.Name = "ClientNID";
            ClientNID.Size = new Size(471, 31);
            ClientNID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 223);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 16;
            label4.Text = "Client NID";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1880, 1300);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(clientTableLayout);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients";
            Load += Clients_Load;
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientIDpic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            clientTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteButton;
        private Button SaveButton;
        private Button EditButton;
        private Panel panel4;
        private Panel panel7;
        private TextBox textBox4;
        private Button UploadButton;
        private Label label8;
        private PictureBox ClientIDpic;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox backBtn;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label3;
        private TextBox ClientContact;
        private Label label2;
        private TextBox ClientAddress;
        private TextBox ClientName;
        private Panel clientTableLayout;
        private DataGridView clientDataGridView;
        private Label label1;
        private Panel panel3;
        private Label label6;
        private TextBox ClientEmail;
        private TextBox ClientNID;
        private Label label4;
    }
}