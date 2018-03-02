namespace Sorting_Algorithms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMain2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbMain
            // 
            this.lbMain.CausesValidation = false;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(127, 13);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(257, 33);
            this.lbMain.TabIndex = 1;
            this.lbMain.Text = "Đại học Quốc gia Thành phố Hồ Chí Minh\r\nTrường Đại học Công nghệ Thông tin\r\n";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMain.Click += new System.EventHandler(this.lbMain_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMain2
            // 
            this.lbMain2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain2.Location = new System.Drawing.Point(127, 57);
            this.lbMain2.Name = "lbMain2";
            this.lbMain2.Size = new System.Drawing.Size(264, 101);
            this.lbMain2.TabIndex = 3;
            this.lbMain2.Text = "Sortalgo 1.0 (Sorting Algorithms)\r\nĐồ án môn Cấu trúc dữ liệu và Giải thuật\r\n© 20" +
    "16 Nguyễn Xuân Hảo\r\n15520203\r\nGiáo viên hướng dẫn: Cáp Phạm Đình Thăng\r\nLiên hệ:" +
    " nxhao235@gmail.com";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 185);
            this.ControlBox = false;
            this.Controls.Add(this.lbMain2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Về chương trình";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMain2;
    }
}