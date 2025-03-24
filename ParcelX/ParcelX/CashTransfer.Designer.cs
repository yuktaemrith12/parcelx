namespace PostalCW
{
    partial class CashTransfer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashTransfer));
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            transferDate = new DateTimePicker();
            label14 = new Label();
            receiverAddress = new TextBox();
            label13 = new Label();
            receiverContact = new TextBox();
            label12 = new Label();
            panel3 = new Panel();
            senderName = new ComboBox();
            TransactionType = new ComboBox();
            receiverName = new TextBox();
            label11 = new Label();
            TransactionStatus = new ComboBox();
            label8 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            senderID = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            Description = new TextBox();
            label1 = new Label();
            Amount = new TextBox();
            dataGridTransfer = new DataGridView();
            deleteButton = new Button();
            saveButton = new Button();
            editButton = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            backBtn = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransfer).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Cornsilk;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(76, 13);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(276, 38);
            textBox6.TabIndex = 0;
            textBox6.Text = "SENDER DETAILS";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Cornsilk;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(67, 13);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(276, 38);
            textBox7.TabIndex = 0;
            textBox7.Text = "RECEIVER DETAILS";
            // 
            // transferDate
            // 
            transferDate.Location = new Point(638, 323);
            transferDate.Name = "transferDate";
            transferDate.Size = new Size(413, 31);
            transferDate.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(638, 291);
            label14.Name = "label14";
            label14.Size = new Size(165, 29);
            label14.TabIndex = 28;
            label14.Text = "Transfer Date";
            // 
            // receiverAddress
            // 
            receiverAddress.Location = new Point(1205, 311);
            receiverAddress.Multiline = true;
            receiverAddress.Name = "receiverAddress";
            receiverAddress.Size = new Size(475, 78);
            receiverAddress.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1205, 279);
            label13.Name = "label13";
            label13.Size = new Size(212, 29);
            label13.TabIndex = 26;
            label13.Text = "Receiver Address";
            // 
            // receiverContact
            // 
            receiverContact.Location = new Point(1205, 222);
            receiverContact.Name = "receiverContact";
            receiverContact.Size = new Size(415, 31);
            receiverContact.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1205, 190);
            label12.Name = "label12";
            label12.Size = new Size(207, 29);
            label12.TabIndex = 24;
            label12.Text = "Receiver Contact";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(senderName);
            panel3.Controls.Add(TransactionType);
            panel3.Controls.Add(transferDate);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(receiverAddress);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(receiverContact);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(receiverName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(TransactionStatus);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(senderID);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Description);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Amount);
            panel3.Location = new Point(28, 767);
            panel3.Name = "panel3";
            panel3.Size = new Size(1823, 511);
            panel3.TabIndex = 13;
            // 
            // senderName
            // 
            senderName.FormattingEnabled = true;
            senderName.Location = new Point(636, 133);
            senderName.Name = "senderName";
            senderName.Size = new Size(415, 33);
            senderName.TabIndex = 31;
            // 
            // TransactionType
            // 
            TransactionType.FormattingEnabled = true;
            TransactionType.Items.AddRange(new object[] { "Send Money", "Receive Money", "Deposit", "Bill Payment" });
            TransactionType.Location = new Point(69, 225);
            TransactionType.Name = "TransactionType";
            TransactionType.Size = new Size(473, 33);
            TransactionType.TabIndex = 30;
            // 
            // receiverName
            // 
            receiverName.Location = new Point(1205, 133);
            receiverName.Name = "receiverName";
            receiverName.Size = new Size(415, 31);
            receiverName.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1205, 101);
            label11.Name = "label11";
            label11.Size = new Size(182, 29);
            label11.TabIndex = 22;
            label11.Text = "Receiver Name";
            // 
            // TransactionStatus
            // 
            TransactionStatus.FormattingEnabled = true;
            TransactionStatus.Items.AddRange(new object[] { "Pending", "Completed", "Failed" });
            TransactionStatus.Location = new Point(1315, 462);
            TransactionStatus.Name = "TransactionStatus";
            TransactionStatus.Size = new Size(473, 33);
            TransactionStatus.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1205, 466);
            label8.Name = "label8";
            label8.Size = new Size(105, 29);
            label8.TabIndex = 18;
            label8.Text = "STATUS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cornsilk;
            panel6.Controls.Add(textBox7);
            panel6.Location = new Point(1205, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(441, 63);
            panel6.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cornsilk;
            panel5.Controls.Add(textBox6);
            panel5.Location = new Point(638, 22);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 63);
            panel5.TabIndex = 16;
            // 
            // senderID
            // 
            senderID.Location = new Point(638, 225);
            senderID.Name = "senderID";
            senderID.Size = new Size(413, 31);
            senderID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(636, 104);
            label4.Name = "label4";
            label4.Size = new Size(165, 29);
            label4.TabIndex = 16;
            label4.Text = "Sender Name";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Cornsilk;
            panel7.Controls.Add(textBox4);
            panel7.Location = new Point(71, 22);
            panel7.Name = "panel7";
            panel7.Size = new Size(441, 63);
            panel7.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cornsilk;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(68, 13);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(317, 38);
            textBox4.TabIndex = 0;
            textBox4.Text = "TRANSFER DETAILS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(638, 193);
            label7.Name = "label7";
            label7.Size = new Size(125, 29);
            label7.TabIndex = 11;
            label7.Text = "Sender ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 279);
            label5.Name = "label5";
            label5.Size = new Size(145, 29);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 193);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 3;
            label3.Text = "Transaction Type";
            // 
            // Description
            // 
            Description.Location = new Point(72, 311);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(475, 75);
            Description.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 104);
            label1.Name = "label1";
            label1.Size = new Size(211, 29);
            label1.TabIndex = 0;
            label1.Text = "Amount (in MUR)";
            // 
            // Amount
            // 
            Amount.Location = new Point(70, 136);
            Amount.Name = "Amount";
            Amount.Size = new Size(474, 31);
            Amount.TabIndex = 0;
            // 
            // dataGridTransfer
            // 
            dataGridTransfer.BackgroundColor = Color.White;
            dataGridTransfer.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Goldenrod;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridTransfer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Cornsilk;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridTransfer.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridTransfer.Location = new Point(16, 13);
            dataGridTransfer.Name = "dataGridTransfer";
            dataGridTransfer.RowHeadersWidth = 62;
            dataGridTransfer.Size = new Size(1516, 490);
            dataGridTransfer.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkGoldenrod;
            deleteButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(58, 275);
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
            saveButton.Location = new Point(58, 168);
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
            editButton.Location = new Point(58, 63);
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
            panel4.Location = new Point(1588, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 414);
            panel4.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1880, 180);
            panel1.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1662, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2059, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 99);
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
            label10.Location = new Point(765, 101);
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
            label9.Location = new Point(799, 11);
            label9.Name = "label9";
            label9.Size = new Size(346, 90);
            label9.TabIndex = 0;
            label9.Text = "Transfers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridTransfer);
            panel2.Location = new Point(28, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 525);
            panel2.TabIndex = 12;
            // 
            // CashTransfer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1880, 1300);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashTransfer";
            Load += CashTransfer_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransfer).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox7;
        private DateTimePicker transferDate;
        private Label label14;
        private TextBox receiverAddress;
        private Label label13;
        private TextBox receiverContact;
        private Label label12;
        private Panel panel3;
        private TextBox receiverName;
        private Label label11;
        private ComboBox TransactionStatus;
        private Label label8;
        private Panel panel6;
        private Panel panel5;
        private TextBox senderID;
        private Label label4;
        private Panel panel7;
        private TextBox textBox4;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox Description;
        private Label label1;
        private TextBox Amount;
        private DataGridView dataGridTransfer;
        private Button deleteButton;
        private Button saveButton;
        private Button editButton;
        private Panel panel4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox backBtn;
        private Label label10;
        private Label label9;
        private Panel panel2;
        private ComboBox TransactionType;
        private PictureBox pictureBox4;
        private ComboBox senderName;
    }
}