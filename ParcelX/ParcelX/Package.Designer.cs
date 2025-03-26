namespace PostalCW
{
    partial class Package
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            deleteButton = new Button();
            saveButton = new Button();
            editButton = new Button();
            panel4 = new Panel();
            panel7 = new Panel();
            textBox4 = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            backBtn = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dataGridViewPackage = new DataGridView();
            panel3 = new Panel();
            label6 = new Label();
            OfficerName = new ComboBox();
            label15 = new Label();
            OfficerID = new TextBox();
            panel8 = new Panel();
            textBox11 = new TextBox();
            DropDate = new DateTimePicker();
            label14 = new Label();
            ReceiverAddress = new TextBox();
            label13 = new Label();
            ReceiverContact = new TextBox();
            label12 = new Label();
            ReceiverName = new TextBox();
            label11 = new Label();
            Priority = new ComboBox();
            label8 = new Label();
            panel6 = new Panel();
            textBox7 = new TextBox();
            panel5 = new Panel();
            textBox6 = new TextBox();
            SenderID = new TextBox();
            label4 = new Label();
            label7 = new Label();
            SenderName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            Weight = new TextBox();
            Content = new TextBox();
            label1 = new Label();
            Dimension = new TextBox();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackage).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkGoldenrod;
            deleteButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(58, 269);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 50);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Goldenrod;
            saveButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(58, 161);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 50);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Goldenrod;
            editButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(58, 59);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 50);
            editButton.TabIndex = 0;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(saveButton);
            panel4.Controls.Add(editButton);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(1599, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 388);
            panel4.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Cornsilk;
            panel7.Controls.Add(textBox4);
            panel7.Location = new Point(95, 18);
            panel7.Name = "panel7";
            panel7.Size = new Size(473, 63);
            panel7.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cornsilk;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(61, 13);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(364, 38);
            textBox4.TabIndex = 0;
            textBox4.Text = "PACKAGE INFORMATION";
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
            pictureBox3.Location = new Point(1685, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(34, 38);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 99);
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
            label10.Location = new Point(770, 112);
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
            label9.Location = new Point(606, 22);
            label9.Name = "label9";
            label9.Size = new Size(818, 90);
            label9.TabIndex = 0;
            label9.Text = "Package Administration";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewPackage);
            panel2.Location = new Point(28, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(1546, 525);
            panel2.TabIndex = 7;
            // 
            // dataGridViewPackage
            // 
            dataGridViewPackage.BackgroundColor = Color.White;
            dataGridViewPackage.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Goldenrod;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPackage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.OldLace;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPackage.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPackage.Location = new Point(16, 13);
            dataGridViewPackage.Name = "dataGridViewPackage";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Goldenrod;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPackage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPackage.RowHeadersWidth = 62;
            dataGridViewPackage.Size = new Size(1511, 490);
            dataGridViewPackage.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(OfficerName);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(OfficerID);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(DropDate);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(ReceiverAddress);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(ReceiverContact);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(ReceiverName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(Priority);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(SenderID);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(SenderName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Weight);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Content);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Dimension);
            panel3.Location = new Point(28, 735);
            panel3.Name = "panel3";
            panel3.Size = new Size(1828, 553);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1303, 189);
            label6.Name = "label6";
            label6.Size = new Size(120, 29);
            label6.TabIndex = 34;
            label6.Text = "Officer ID";
            // 
            // OfficerName
            // 
            OfficerName.FormattingEnabled = true;
            OfficerName.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract" });
            OfficerName.Location = new Point(1304, 135);
            OfficerName.Name = "OfficerName";
            OfficerName.Size = new Size(473, 33);
            OfficerName.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1303, 100);
            label15.Name = "label15";
            label15.Size = new Size(160, 29);
            label15.TabIndex = 31;
            label15.Text = "Officer Name";
            // 
            // OfficerID
            // 
            OfficerID.Location = new Point(1305, 221);
            OfficerID.Name = "OfficerID";
            OfficerID.Size = new Size(473, 31);
            OfficerID.TabIndex = 32;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Cornsilk;
            panel8.Controls.Add(textBox11);
            panel8.Location = new Point(1303, 18);
            panel8.Name = "panel8";
            panel8.Size = new Size(476, 63);
            panel8.TabIndex = 30;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Cornsilk;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(81, 13);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(337, 38);
            textBox11.TabIndex = 0;
            textBox11.Text = "DELIVERY OPERATION";
            // 
            // DropDate
            // 
            DropDate.Location = new Point(1303, 319);
            DropDate.Name = "DropDate";
            DropDate.Size = new Size(474, 31);
            DropDate.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(1303, 287);
            label14.Name = "label14";
            label14.Size = new Size(127, 29);
            label14.TabIndex = 28;
            label14.Text = "Drop Date";
            // 
            // ReceiverAddress
            // 
            ReceiverAddress.Location = new Point(710, 475);
            ReceiverAddress.Multiline = true;
            ReceiverAddress.Name = "ReceiverAddress";
            ReceiverAddress.Size = new Size(475, 60);
            ReceiverAddress.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(710, 443);
            label13.Name = "label13";
            label13.Size = new Size(212, 29);
            label13.TabIndex = 26;
            label13.Text = "Receiver Address";
            // 
            // ReceiverContact
            // 
            ReceiverContact.Location = new Point(710, 386);
            ReceiverContact.Name = "ReceiverContact";
            ReceiverContact.Size = new Size(475, 31);
            ReceiverContact.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(710, 354);
            label12.Name = "label12";
            label12.Size = new Size(207, 29);
            label12.TabIndex = 24;
            label12.Text = "Receiver Contact";
            // 
            // ReceiverName
            // 
            ReceiverName.Location = new Point(710, 297);
            ReceiverName.Name = "ReceiverName";
            ReceiverName.Size = new Size(475, 31);
            ReceiverName.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(710, 265);
            label11.Name = "label11";
            label11.Size = new Size(182, 29);
            label11.TabIndex = 22;
            label11.Text = "Receiver Name";
            // 
            // Priority
            // 
            Priority.FormattingEnabled = true;
            Priority.Items.AddRange(new object[] { "Standard", "Express", "Same-Day" });
            Priority.Location = new Point(95, 319);
            Priority.Name = "Priority";
            Priority.Size = new Size(473, 33);
            Priority.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(93, 287);
            label8.Name = "label8";
            label8.Size = new Size(196, 29);
            label8.TabIndex = 18;
            label8.Text = "Delivery Priority";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cornsilk;
            panel6.Controls.Add(textBox7);
            panel6.Location = new Point(710, 189);
            panel6.Name = "panel6";
            panel6.Size = new Size(475, 63);
            panel6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Cornsilk;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(94, 13);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(276, 38);
            textBox7.TabIndex = 0;
            textBox7.Text = "RECEIVER DETAILS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cornsilk;
            panel5.Controls.Add(textBox6);
            panel5.Location = new Point(710, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(475, 63);
            panel5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Cornsilk;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(94, 13);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(276, 38);
            textBox6.TabIndex = 0;
            textBox6.Text = "SENDER DETAILS";
            // 
            // SenderID
            // 
            SenderID.Location = new Point(1011, 130);
            SenderID.Name = "SenderID";
            SenderID.Size = new Size(174, 31);
            SenderID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(710, 98);
            label4.Name = "label4";
            label4.Size = new Size(165, 29);
            label4.TabIndex = 16;
            label4.Text = "Sender Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1011, 98);
            label7.Name = "label7";
            label7.Size = new Size(125, 29);
            label7.TabIndex = 11;
            label7.Text = "Sender ID";
            // 
            // SenderName
            // 
            SenderName.FormattingEnabled = true;
            SenderName.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract" });
            SenderName.Location = new Point(710, 130);
            SenderName.Name = "SenderName";
            SenderName.Size = new Size(269, 33);
            SenderName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 373);
            label5.Name = "label5";
            label5.Size = new Size(243, 29);
            label5.TabIndex = 8;
            label5.Text = "Content Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 189);
            label3.Name = "label3";
            label3.Size = new Size(217, 29);
            label3.TabIndex = 3;
            label3.Text = "Weight (in grams)";
            // 
            // Weight
            // 
            Weight.Location = new Point(93, 221);
            Weight.Name = "Weight";
            Weight.Size = new Size(475, 31);
            Weight.TabIndex = 4;
            // 
            // Content
            // 
            Content.Location = new Point(94, 405);
            Content.Multiline = true;
            Content.Name = "Content";
            Content.Size = new Size(475, 130);
            Content.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 100);
            label1.Name = "label1";
            label1.Size = new Size(351, 29);
            label1.TabIndex = 0;
            label1.Text = "Dimensions L x W x H (in cm)";
            // 
            // Dimension
            // 
            Dimension.Location = new Point(94, 132);
            Dimension.Name = "Dimension";
            Dimension.Size = new Size(474, 31);
            Dimension.TabIndex = 0;
            // 
            // Package
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1880, 1300);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Package";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Package";
            Load += Package_Load;
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button deleteButton;
        private Button saveButton;
        private Button editButton;
        private Panel panel4;
        private Panel panel7;
        private TextBox textBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox backBtn;
        private Label label10;
        private Label label9;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridViewPackage;
        private Panel panel3;
        private Panel panel6;
        private TextBox textBox7;
        private Panel panel5;
        private TextBox textBox6;
        private TextBox SenderID;
        private Label label4;
        private Label label7;
        private ComboBox SenderName;
        private Label label5;
        private Label label3;
        private TextBox Weight;
        private TextBox Content;
        private Label label1;
        private TextBox Dimension;
        private ComboBox Priority;
        private Label label8;
        private Label label13;
        private TextBox ReceiverContact;
        private Label label12;
        private TextBox ReceiverName;
        private Label label11;
        private DateTimePicker DropDate;
        private Label label14;
        private TextBox ReceiverAddress;
        private Panel panel8;
        private TextBox textBox11;
        private Label label6;
        private ComboBox OfficerName;
        private Label label15;
        private TextBox OfficerID;
    }
}