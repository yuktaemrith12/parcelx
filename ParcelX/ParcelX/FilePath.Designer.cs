namespace PostalCW
{
    partial class FilePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePath));
            textfilePath = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            SkipBtn = new Button();
            BrowseBtn = new Button();
            NextBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textfilePath
            // 
            textfilePath.Location = new Point(382, 334);
            textfilePath.Name = "textfilePath";
            textfilePath.Size = new Size(284, 31);
            textfilePath.TabIndex = 0;
            textfilePath.TextChanged += textfilePath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 327);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 1;
            label1.Text = "Enter Path Here :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 109);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 26);
            label2.Name = "label2";
            label2.Size = new Size(268, 55);
            label2.TabIndex = 3;
            label2.Text = "Login Portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 159);
            label3.Name = "label3";
            label3.Size = new Size(537, 66);
            label3.TabIndex = 3;
            label3.Text = "                                    WELCOME!\r\n  Please enter the path to the text file you wish to import, \r\n           or click Skip to use existing database records.";
            // 
            // SkipBtn
            // 
            SkipBtn.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SkipBtn.Location = new Point(35, 470);
            SkipBtn.Name = "SkipBtn";
            SkipBtn.Size = new Size(143, 47);
            SkipBtn.TabIndex = 5;
            SkipBtn.Text = "Skip";
            SkipBtn.UseVisualStyleBackColor = true;
            SkipBtn.Click += SkipBtn_Click;
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(672, 330);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(102, 38);
            BrowseBtn.TabIndex = 6;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextBtn.Location = new Point(778, 470);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(143, 47);
            NextBtn.TabIndex = 7;
            NextBtn.Text = "Next > ";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // FilePath
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(950, 552);
            Controls.Add(NextBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(SkipBtn);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textfilePath);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilePath";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FilePath_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textfilePath;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button SkipBtn;
        private Button BrowseBtn;
        private Button NextBtn;
    }
}