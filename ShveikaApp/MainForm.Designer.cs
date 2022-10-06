namespace ShveikaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopRightPanel = new System.Windows.Forms.Panel();
            this.DescChk = new System.Windows.Forms.CheckBox();
            this.FiltrCmb = new System.Windows.Forms.ComboBox();
            this.Sortcmb = new System.Windows.Forms.ComboBox();
            this.UserCredentialsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdCountLbl = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.CompanyTitleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ProdLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel.SuspendLayout();
            this.TopRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.TopPanel.Controls.Add(this.TopRightPanel);
            this.TopPanel.Controls.Add(this.SearchTxt);
            this.TopPanel.Controls.Add(this.CompanyTitleLbl);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1031, 114);
            this.TopPanel.TabIndex = 0;
            // 
            // TopRightPanel
            // 
            this.TopRightPanel.Controls.Add(this.DescChk);
            this.TopRightPanel.Controls.Add(this.FiltrCmb);
            this.TopRightPanel.Controls.Add(this.Sortcmb);
            this.TopRightPanel.Controls.Add(this.UserCredentialsLbl);
            this.TopRightPanel.Controls.Add(this.label1);
            this.TopRightPanel.Controls.Add(this.ProdCountLbl);
            this.TopRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopRightPanel.Location = new System.Drawing.Point(387, 0);
            this.TopRightPanel.Name = "TopRightPanel";
            this.TopRightPanel.Size = new System.Drawing.Size(644, 114);
            this.TopRightPanel.TabIndex = 4;
            // 
            // DescChk
            // 
            this.DescChk.AutoSize = true;
            this.DescChk.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescChk.ForeColor = System.Drawing.Color.White;
            this.DescChk.Location = new System.Drawing.Point(223, 66);
            this.DescChk.Name = "DescChk";
            this.DescChk.Size = new System.Drawing.Size(131, 24);
            this.DescChk.TabIndex = 5;
            this.DescChk.Text = "По убыванию";
            this.DescChk.UseVisualStyleBackColor = true;
            this.DescChk.CheckedChanged += new System.EventHandler(this.DescChk_CheckedChanged);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.FiltrCmb.Location = new System.Drawing.Point(422, 64);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(159, 26);
            this.FiltrCmb.TabIndex = 4;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // Sortcmb
            // 
            this.Sortcmb.FormattingEnabled = true;
            this.Sortcmb.Items.AddRange(new object[] {
            "Без сортировки",
            "Стоимость"});
            this.Sortcmb.Location = new System.Drawing.Point(24, 64);
            this.Sortcmb.Name = "Sortcmb";
            this.Sortcmb.Size = new System.Drawing.Size(193, 26);
            this.Sortcmb.TabIndex = 4;
            this.Sortcmb.SelectedIndexChanged += new System.EventHandler(this.Sortcmb_SelectedIndexChanged);
            // 
            // UserCredentialsLbl
            // 
            this.UserCredentialsLbl.AutoSize = true;
            this.UserCredentialsLbl.ForeColor = System.Drawing.Color.White;
            this.UserCredentialsLbl.Location = new System.Drawing.Point(548, 18);
            this.UserCredentialsLbl.Name = "UserCredentialsLbl";
            this.UserCredentialsLbl.Size = new System.Drawing.Size(33, 18);
            this.UserCredentialsLbl.TabIndex = 3;
            this.UserCredentialsLbl.Text = "FIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продуктов:";
            // 
            // ProdCountLbl
            // 
            this.ProdCountLbl.AutoSize = true;
            this.ProdCountLbl.ForeColor = System.Drawing.Color.White;
            this.ProdCountLbl.Location = new System.Drawing.Point(93, 18);
            this.ProdCountLbl.Name = "ProdCountLbl";
            this.ProdCountLbl.Size = new System.Drawing.Size(22, 18);
            this.ProdCountLbl.TabIndex = 2;
            this.ProdCountLbl.Text = "из";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(173, 64);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(208, 26);
            this.SearchTxt.TabIndex = 3;
            this.SearchTxt.Text = "Введите для поиска";
            this.SearchTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTxt_MouseClick);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // CompanyTitleLbl
            // 
            this.CompanyTitleLbl.AutoSize = true;
            this.CompanyTitleLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyTitleLbl.ForeColor = System.Drawing.Color.White;
            this.CompanyTitleLbl.Location = new System.Drawing.Point(168, 9);
            this.CompanyTitleLbl.Name = "CompanyTitleLbl";
            this.CompanyTitleLbl.Size = new System.Drawing.Size(132, 27);
            this.CompanyTitleLbl.TabIndex = 1;
            this.CompanyTitleLbl.Text = "ИС \"Швейка\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.BottomPanel.Controls.Add(this.LogoutBtn);
            this.BottomPanel.Controls.Add(this.AddBtn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomPanel.Location = new System.Drawing.Point(0, 504);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1031, 100);
            this.BottomPanel.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(832, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(136, 47);
            this.LogoutBtn.TabIndex = 0;
            this.LogoutBtn.Text = "Выйти из аккаунта";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(34, 30);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(136, 47);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.ProdLayoutPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 114);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1031, 390);
            this.CenterPanel.TabIndex = 2;
            // 
            // ProdLayoutPanel
            // 
            this.ProdLayoutPanel.AutoScroll = true;
            this.ProdLayoutPanel.AutoSize = true;
            this.ProdLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ProdLayoutPanel.Name = "ProdLayoutPanel";
            this.ProdLayoutPanel.Size = new System.Drawing.Size(1031, 390);
            this.ProdLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 604);
            this.ControlBox = false;
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1047, 643);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС \"Швейка\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TopRightPanel.ResumeLayout(false);
            this.TopRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label ProdCountLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CompanyTitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.FlowLayoutPanel ProdLayoutPanel;
        private System.Windows.Forms.Panel TopRightPanel;
        private System.Windows.Forms.Label UserCredentialsLbl;
        private System.Windows.Forms.CheckBox DescChk;
        private System.Windows.Forms.ComboBox FiltrCmb;
        private System.Windows.Forms.ComboBox Sortcmb;
        private System.Windows.Forms.Button LogoutBtn;
    }
}

