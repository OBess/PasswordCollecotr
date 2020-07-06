namespace PasswordCollector
{
    partial class LoginWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.LinkLabel();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.logProblemLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(32, 30);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(42, 14);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Login";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(32, 89);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(63, 14);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.createAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createAccountBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createAccountBtn.LinkColor = System.Drawing.Color.Black;
            this.createAccountBtn.Location = new System.Drawing.Point(0, 299);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(284, 25);
            this.createAccountBtn.TabIndex = 2;
            this.createAccountBtn.TabStop = true;
            this.createAccountBtn.Text = "Create account";
            this.createAccountBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createAccountBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountBtn_LinkClicked);
            // 
            // loginTb
            // 
            this.loginTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTb.Location = new System.Drawing.Point(35, 46);
            this.loginTb.MaxLength = 32;
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(214, 23);
            this.loginTb.TabIndex = 3;
            this.loginTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTb_KeyDown);
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTb.Location = new System.Drawing.Point(35, 105);
            this.passwordTb.MaxLength = 32;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(214, 23);
            this.passwordTb.TabIndex = 4;
            this.passwordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTb_KeyDown);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(86, 173);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(110, 23);
            this.logInBtn.TabIndex = 5;
            this.logInBtn.Text = "Log in";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // logProblemLbl
            // 
            this.logProblemLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logProblemLbl.ForeColor = System.Drawing.Color.Red;
            this.logProblemLbl.Location = new System.Drawing.Point(0, 215);
            this.logProblemLbl.Name = "logProblemLbl";
            this.logProblemLbl.Size = new System.Drawing.Size(284, 84);
            this.logProblemLbl.TabIndex = 6;
            this.logProblemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.logProblemLbl);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.LinkLabel createAccountBtn;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Label logProblemLbl;
    }
}

