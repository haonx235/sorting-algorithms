namespace Sorting_Algorithms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSelection = new System.Windows.Forms.Label();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbBrowse = new System.Windows.Forms.Label();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tbNumberOfElements = new System.Windows.Forms.TextBox();
            this.lbNumberOfElements = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.rbFromFile = new System.Windows.Forms.RadioButton();
            this.rbFromKeyboard = new System.Windows.Forms.RadioButton();
            this.rbRandomize = new System.Windows.Forms.RadioButton();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.gbIdea = new System.Windows.Forms.GroupBox();
            this.tbIdea = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btRestoreToDefault = new System.Windows.Forms.Button();
            this.MainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbGenerate.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.gbIdea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnInitialize";
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msGuide,
            this.msAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(63, 20);
            this.msHelp.Text = "Trợ giú&p";
            this.msHelp.Click += new System.EventHandler(this.msHelp_Click);
            // 
            // msGuide
            // 
            this.msGuide.Name = "msGuide";
            this.msGuide.Size = new System.Drawing.Size(159, 22);
            this.msGuide.Text = "Hướng dẫn";
            this.msGuide.Click += new System.EventHandler(this.msGuide_Click);
            // 
            // msAbout
            // 
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(159, 22);
            this.msAbout.Text = "Về chương trình";
            this.msAbout.Click += new System.EventHandler(this.msAbout_Click);
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelection.Location = new System.Drawing.Point(12, 212);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(136, 15);
            this.lbSelection.TabIndex = 1;
            this.lbSelection.Text = "Chọn thuật toán sắp xếp";
            this.lbSelection.Click += new System.EventHandler(this.lbSelection_Click);
            // 
            // cbSelection
            // 
            this.cbSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Items.AddRange(new object[] {
            "Interchange sort (Đổi chỗ trực tiếp)",
            "Bubble sort (Sắp xếp nổi bọt)",
            "Selection sort (Sắp xếp chọn trực tiếp)",
            "Heap sort (Sắp xếp vun đống)",
            "Merge sort (Sắp xếp trộn)",
            "Quick sort (Sắp xếp nhanh)",
            "Insertion sort (Sắp xếp chèn)"});
            this.cbSelection.Location = new System.Drawing.Point(15, 230);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(281, 23);
            this.cbSelection.TabIndex = 10;
            this.cbSelection.SelectedIndexChanged += new System.EventHandler(this.cbSelection_SelectedIndexChanged);
            // 
            // gbGenerate
            // 
            this.gbGenerate.Controls.Add(this.tbInput);
            this.gbGenerate.Controls.Add(this.lbInput);
            this.gbGenerate.Controls.Add(this.lbBrowse);
            this.gbGenerate.Controls.Add(this.btBrowse);
            this.gbGenerate.Controls.Add(this.tbNumberOfElements);
            this.gbGenerate.Controls.Add(this.lbNumberOfElements);
            this.gbGenerate.Controls.Add(this.btGenerate);
            this.gbGenerate.Controls.Add(this.rbFromFile);
            this.gbGenerate.Controls.Add(this.rbFromKeyboard);
            this.gbGenerate.Controls.Add(this.rbRandomize);
            this.gbGenerate.Location = new System.Drawing.Point(10, 32);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.Size = new System.Drawing.Size(427, 177);
            this.gbGenerate.TabIndex = 17;
            this.gbGenerate.TabStop = false;
            this.gbGenerate.Text = "Phương thức khởi tạo";
            this.gbGenerate.Enter += new System.EventHandler(this.gbGenerate_Enter);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(9, 92);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(410, 23);
            this.tbInput.TabIndex = 26;
            this.tbInput.TextChanged += new System.EventHandler(this.tbChanged_TextChanged);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(6, 72);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(325, 15);
            this.lbInput.TabIndex = 25;
            this.lbInput.Text = "Nhập vào một dãy số (các phân tử cách nhau bởi dấu cách):";
            // 
            // lbBrowse
            // 
            this.lbBrowse.AutoSize = true;
            this.lbBrowse.Enabled = false;
            this.lbBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBrowse.Location = new System.Drawing.Point(6, 123);
            this.lbBrowse.Name = "lbBrowse";
            this.lbBrowse.Size = new System.Drawing.Size(189, 15);
            this.lbBrowse.TabIndex = 24;
            this.lbBrowse.Text = "Chọn tệp chứa dãy số cần sắp xếp:";
            this.lbBrowse.Click += new System.EventHandler(this.lbBrowse_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Enabled = false;
            this.btBrowse.Location = new System.Drawing.Point(227, 121);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 23;
            this.btBrowse.Text = "Duyệt";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tbNumberOfElements
            // 
            this.tbNumberOfElements.Location = new System.Drawing.Point(227, 44);
            this.tbNumberOfElements.Name = "tbNumberOfElements";
            this.tbNumberOfElements.Size = new System.Drawing.Size(57, 23);
            this.tbNumberOfElements.TabIndex = 22;
            // 
            // lbNumberOfElements
            // 
            this.lbNumberOfElements.AutoSize = true;
            this.lbNumberOfElements.Location = new System.Drawing.Point(6, 47);
            this.lbNumberOfElements.Name = "lbNumberOfElements";
            this.lbNumberOfElements.Size = new System.Drawing.Size(182, 15);
            this.lbNumberOfElements.TabIndex = 21;
            this.lbNumberOfElements.Text = "Số phần tử khởi tạo (từ 1 đến 30):";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(9, 147);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(66, 22);
            this.btGenerate.TabIndex = 20;
            this.btGenerate.Text = "Khởi tạo";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // rbFromFile
            // 
            this.rbFromFile.AutoSize = true;
            this.rbFromFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromFile.Location = new System.Drawing.Point(243, 22);
            this.rbFromFile.Name = "rbFromFile";
            this.rbFromFile.Size = new System.Drawing.Size(88, 19);
            this.rbFromFile.TabIndex = 19;
            this.rbFromFile.TabStop = true;
            this.rbFromFile.Text = "Nhập từ tệp";
            this.rbFromFile.UseVisualStyleBackColor = true;
            this.rbFromFile.CheckedChanged += new System.EventHandler(this.rbTypeOfGeneration_CheckedChanged);
            // 
            // rbFromKeyboard
            // 
            this.rbFromKeyboard.AutoSize = true;
            this.rbFromKeyboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromKeyboard.Location = new System.Drawing.Point(115, 22);
            this.rbFromKeyboard.Name = "rbFromKeyboard";
            this.rbFromKeyboard.Size = new System.Drawing.Size(122, 19);
            this.rbFromKeyboard.TabIndex = 18;
            this.rbFromKeyboard.TabStop = true;
            this.rbFromKeyboard.Text = "Nhập từ bàn phím";
            this.rbFromKeyboard.UseVisualStyleBackColor = true;
            this.rbFromKeyboard.CheckedChanged += new System.EventHandler(this.rbTypeOfGeneration_CheckedChanged);
            // 
            // rbRandomize
            // 
            this.rbRandomize.AutoSize = true;
            this.rbRandomize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRandomize.Location = new System.Drawing.Point(9, 22);
            this.rbRandomize.Name = "rbRandomize";
            this.rbRandomize.Size = new System.Drawing.Size(87, 19);
            this.rbRandomize.TabIndex = 17;
            this.rbRandomize.TabStop = true;
            this.rbRandomize.Text = "Ngẫu nhiên";
            this.rbRandomize.UseVisualStyleBackColor = true;
            this.rbRandomize.CheckedChanged += new System.EventHandler(this.rbTypeOfGeneration_CheckedChanged);
            // 
            // gbProgram
            // 
            this.gbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProgram.Controls.Add(this.tbProgram);
            this.gbProgram.Location = new System.Drawing.Point(443, 133);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(397, 154);
            this.gbProgram.TabIndex = 19;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Chương trình";
            this.gbProgram.Enter += new System.EventHandler(this.gbProgram_Enter);
            // 
            // tbProgram
            // 
            this.tbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProgram.BackColor = System.Drawing.SystemColors.Control;
            this.tbProgram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProgram.Location = new System.Drawing.Point(6, 22);
            this.tbProgram.Multiline = true;
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.ReadOnly = true;
            this.tbProgram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProgram.Size = new System.Drawing.Size(385, 126);
            this.tbProgram.TabIndex = 0;
            // 
            // gbIdea
            // 
            this.gbIdea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIdea.Controls.Add(this.tbIdea);
            this.gbIdea.Location = new System.Drawing.Point(443, 32);
            this.gbIdea.Name = "gbIdea";
            this.gbIdea.Size = new System.Drawing.Size(397, 95);
            this.gbIdea.TabIndex = 20;
            this.gbIdea.TabStop = false;
            this.gbIdea.Text = "Ý tưởng thuật toán";
            // 
            // tbIdea
            // 
            this.tbIdea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdea.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdea.Location = new System.Drawing.Point(6, 24);
            this.tbIdea.Multiline = true;
            this.tbIdea.Name = "tbIdea";
            this.tbIdea.ReadOnly = true;
            this.tbIdea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIdea.Size = new System.Drawing.Size(385, 65);
            this.tbIdea.TabIndex = 0;
            this.tbIdea.TextChanged += new System.EventHandler(this.tbChanged_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(15, 293);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(819, 186);
            this.tbResult.TabIndex = 22;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(15, 264);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(124, 23);
            this.btRun.TabIndex = 23;
            this.btRun.Text = "Chạy chương trình";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btRestoreToDefault
            // 
            this.btRestoreToDefault.Location = new System.Drawing.Point(148, 264);
            this.btRestoreToDefault.Name = "btRestoreToDefault";
            this.btRestoreToDefault.Size = new System.Drawing.Size(146, 23);
            this.btRestoreToDefault.TabIndex = 26;
            this.btRestoreToDefault.Text = "Khôi phục mặc định";
            this.btRestoreToDefault.UseVisualStyleBackColor = true;
            this.btRestoreToDefault.Click += new System.EventHandler(this.btRestoreToDefault_Click);
            // 
            // MainFormBindingSource
            // 
            this.MainFormBindingSource.DataSource = typeof(Sorting_Algorithms.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.cbSelection);
            this.Controls.Add(this.btRestoreToDefault);
            this.Controls.Add(this.lbSelection);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.gbIdea);
            this.Controls.Add(this.gbProgram);
            this.Controls.Add(this.gbGenerate);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sortalgo 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbGenerate.ResumeLayout(false);
            this.gbGenerate.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.gbIdea.ResumeLayout(false);
            this.gbIdea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msGuide;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.Label lbSelection;
        private System.Windows.Forms.BindingSource MainFormBindingSource;
        private System.Windows.Forms.ComboBox cbSelection;
        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.RadioButton rbFromFile;
        private System.Windows.Forms.RadioButton rbFromKeyboard;
        private System.Windows.Forms.RadioButton rbRandomize;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.GroupBox gbIdea;
        private System.Windows.Forms.TextBox tbIdea;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbNumberOfElements;
        private System.Windows.Forms.TextBox tbNumberOfElements;
        private System.Windows.Forms.Label lbBrowse;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btRestoreToDefault;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbProgram;

    }
}