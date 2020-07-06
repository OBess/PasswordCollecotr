namespace PasswordCollector
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
            this.accountTs = new System.Windows.Forms.ToolStrip();
            this.accountSddb = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.listFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.accountTs.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountTs
            // 
            this.accountTs.AutoSize = false;
            this.accountTs.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountTs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSddb});
            this.accountTs.Location = new System.Drawing.Point(0, 0);
            this.accountTs.Name = "accountTs";
            this.accountTs.Size = new System.Drawing.Size(903, 25);
            this.accountTs.TabIndex = 8;
            // 
            // accountSddb
            // 
            this.accountSddb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.accountSddb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.accountSddb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTsmi,
            this.logOutTsmi});
            this.accountSddb.Image = ((System.Drawing.Image)(resources.GetObject("accountSddb.Image")));
            this.accountSddb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accountSddb.Name = "accountSddb";
            this.accountSddb.Size = new System.Drawing.Size(65, 22);
            this.accountSddb.Text = "Account";
            // 
            // settingsTsmi
            // 
            this.settingsTsmi.Name = "settingsTsmi";
            this.settingsTsmi.Size = new System.Drawing.Size(180, 22);
            this.settingsTsmi.Text = "Settings";
            this.settingsTsmi.Click += new System.EventHandler(this.settingsTsmi_Click);
            // 
            // logOutTsmi
            // 
            this.logOutTsmi.Name = "logOutTsmi";
            this.logOutTsmi.Size = new System.Drawing.Size(180, 22);
            this.logOutTsmi.Text = "Log out";
            this.logOutTsmi.Click += new System.EventHandler(this.logOutTsmi_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(19, 29);
            this.searchTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTb.MaxLength = 32;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(199, 23);
            this.searchTb.TabIndex = 14;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // listFlp
            // 
            this.listFlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFlp.AutoScroll = true;
            this.listFlp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listFlp.Location = new System.Drawing.Point(16, 59);
            this.listFlp.MinimumSize = new System.Drawing.Size(390, 108);
            this.listFlp.Name = "listFlp";
            this.listFlp.Size = new System.Drawing.Size(875, 420);
            this.listFlp.TabIndex = 13;
            this.listFlp.WrapContents = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(815, 485);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(903, 520);
            this.Controls.Add(this.accountTs);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.listFlp);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("NSimSun", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(390, 258);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.accountTs.ResumeLayout(false);
            this.accountTs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip accountTs;
        private System.Windows.Forms.ToolStripDropDownButton accountSddb;
        private System.Windows.Forms.ToolStripMenuItem settingsTsmi;
        private System.Windows.Forms.ToolStripMenuItem logOutTsmi;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.FlowLayoutPanel listFlp;
        private System.Windows.Forms.Button addBtn;
    }
}