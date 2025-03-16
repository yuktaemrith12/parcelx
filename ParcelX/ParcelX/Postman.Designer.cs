namespace PostalCW
{
    partial class Postman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postman));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            backBtn = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            postmanDataGridView = new DataGridView();
            panel3 = new Panel();
            panel7 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            OEmploymentType = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            OHireDate = new DateTimePicker();
            label3 = new Label();
            OContact = new TextBox();
            label2 = new Label();
            OAddress = new TextBox();
            label1 = new Label();
            OName = new TextBox();
            panel4 = new Panel();
            EditButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            searchPanel = new Panel();
            CrossIcon = new PictureBox();
            SearchIcon = new PictureBox();
            SearchTextbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)postmanDataGridView).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrossIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1641, 38);
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
            backBtn.Size = new Size(94, 88);
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
            label10.Location = new Point(734, 121);
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
            label9.Location = new Point(612, 31);
            label9.Name = "label9";
            label9.Size = new Size(695, 90);
            label9.TabIndex = 0;
            label9.Text = "Postman Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(postmanDataGridView);
            panel2.Location = new Point(28, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(1801, 541);
            panel2.TabIndex = 1;
            // 
            // postmanDataGridView
            // 
            postmanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            postmanDataGridView.BackgroundColor = Color.White;
            postmanDataGridView.BorderStyle = BorderStyle.None;
            postmanDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Goldenrod;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            postmanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            postmanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.OldLace;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            postmanDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            postmanDataGridView.GridColor = SystemColors.InactiveCaption;
            postmanDataGridView.Location = new Point(56, 33);
            postmanDataGridView.Name = "postmanDataGridView";
            postmanDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Goldenrod;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            postmanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            postmanDataGridView.RowHeadersWidth = 62;
            postmanDataGridView.Size = new Size(1707, 465);
            postmanDataGridView.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(OEmploymentType);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(OHireDate);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(OContact);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(OAddress);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(OName);
            panel3.Location = new Point(28, 800);
            panel3.Name = "panel3";
            panel3.Size = new Size(1381, 427);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Cornsilk;
            panel7.Controls.Add(textBox4);
            panel7.Location = new Point(441, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(729, 63);
            panel7.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cornsilk;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(224, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 38);
            textBox4.TabIndex = 0;
            textBox4.Text = "POSTMAN DETAILS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(575, 277);
            label7.Name = "label7";
            label7.Size = new Size(225, 29);
            label7.TabIndex = 11;
            label7.Text = " Employment Type";
            // 
            // OEmploymentType
            // 
            OEmploymentType.FormattingEnabled = true;
            OEmploymentType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Contract" });
            OEmploymentType.Location = new Point(584, 309);
            OEmploymentType.Name = "OEmploymentType";
            OEmploymentType.Size = new Size(415, 33);
            OEmploymentType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(589, 162);
            label6.Name = "label6";
            label6.Size = new Size(117, 29);
            label6.TabIndex = 9;
            label6.Text = "Hire Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1041, 164);
            label5.Name = "label5";
            label5.Size = new Size(200, 29);
            label5.TabIndex = 8;
            label5.Text = "Current Address";
            // 
            // OHireDate
            // 
            OHireDate.Location = new Point(589, 194);
            OHireDate.Name = "OHireDate";
            OHireDate.Size = new Size(415, 31);
            OHireDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 265);
            label3.Name = "label3";
            label3.Size = new Size(199, 29);
            label3.TabIndex = 3;
            label3.Text = "Contact Number";
            // 
            // OContact
            // 
            OContact.Location = new Point(78, 297);
            OContact.Name = "OContact";
            OContact.Size = new Size(475, 31);
            OContact.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // OAddress
            // 
            OAddress.Location = new Point(1041, 207);
            OAddress.Multiline = true;
            OAddress.Name = "OAddress";
            OAddress.Size = new Size(287, 146);
            OAddress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 152);
            label1.Name = "label1";
            label1.Size = new Size(160, 29);
            label1.TabIndex = 0;
            label1.Text = "Officer Name";
            // 
            // OName
            // 
            OName.Location = new Point(84, 184);
            OName.Name = "OName";
            OName.Size = new Size(474, 31);
            OName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(EditButton);
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(saveButton);
            panel4.ForeColor = Color.DimGray;
            panel4.Location = new Point(1442, 926);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 301);
            panel4.TabIndex = 3;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Goldenrod;
            EditButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(111, 130);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(150, 50);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkGoldenrod;
            deleteButton.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(111, 218);
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
            saveButton.Location = new Point(111, 35);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 50);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.Controls.Add(CrossIcon);
            searchPanel.Controls.Add(SearchIcon);
            searchPanel.Controls.Add(SearchTextbox);
            searchPanel.Location = new Point(1442, 800);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(387, 106);
            searchPanel.TabIndex = 4;
            // 
            // CrossIcon
            // 
            CrossIcon.Image = (Image)resources.GetObject("CrossIcon.Image");
            CrossIcon.Location = new Point(288, 43);
            CrossIcon.Name = "CrossIcon";
            CrossIcon.Size = new Size(34, 30);
            CrossIcon.SizeMode = PictureBoxSizeMode.Zoom;
            CrossIcon.TabIndex = 2;
            CrossIcon.TabStop = false;
            CrossIcon.Click += CrossIcon_Click_1;
            // 
            // SearchIcon
            // 
            SearchIcon.Image = (Image)resources.GetObject("SearchIcon.Image");
            SearchIcon.Location = new Point(328, 36);
            SearchIcon.Name = "SearchIcon";
            SearchIcon.Size = new Size(36, 40);
            SearchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            SearchIcon.TabIndex = 1;
            SearchIcon.TabStop = false;
            SearchIcon.Click += SearchIcon_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextbox.Location = new Point(21, 38);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(301, 35);
            SearchTextbox.TabIndex = 0;
            // 
            // Postman
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1880, 1300);
            Controls.Add(searchPanel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Postman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)postmanDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrossIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox OName;
        private Label label1;
        private Label label2;
        private TextBox OAddress;
        private Label label3;
        private TextBox OContact;
        private DateTimePicker OHireDate;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox OEmploymentType;
        private Panel panel4;
        private Button deleteButton;
        private Button saveButton;
        private Label label10;
        private Label label9;
        private PictureBox backBtn;
        private Panel panel7;
        private TextBox textBox4;
        private PictureBox pictureBox3;
        private DataGridView postmanDataGridView;
        private Button EditButton;
        private Panel searchPanel;
        private TextBox SearchTextbox;
        private PictureBox SearchIcon;
        private PictureBox CrossIcon;
    }
}
