using PasswordCollector.Systems;
using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordCollector
{
    public partial class LoginWindow : Form
    {
        private MainForm main;

        public LoginWindow(MainForm main)
        {
            InitializeComponent();
            init(main);
        }

        public void init(MainForm main)
        {
            this.main = main;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (ValidSystem.IsNotEmpty(logProblemLbl, loginTb.Text, passwordTb.Text))
            {
                if (File.Exists(FileSystem.FolderPath + "/" + EncryptionSystem.EncodePathFile(loginTb.Text + passwordTb.Text) + ".dat"))
                {
                    this.Hide();
                    main.Login(loginTb.Text, FileSystem.FolderPath + "/" + EncryptionSystem.EncodePathFile(loginTb.Text + passwordTb.Text) + ".dat");
                    main.Show();
                    loginTb.Focus();
                    loginTb.Text = "";
                    passwordTb.Text = "";
                    logProblemLbl.Text = "";
                }
                else
                {
                    logProblemLbl.Text = "Your input is failed or this account is not exist. You can create a new account by clicking the button below.";
                    passwordTb.Text = "";
                }
            }
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Close();
        }

        private void createAccountBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidSystem.IsNotEmpty(logProblemLbl, loginTb.Text, passwordTb.Text))
            {
                foreach(var file in Directory.GetFiles(FileSystem.FolderPath))
                    if (EncryptionSystem.EncodePathFile(file).Contains(loginTb.Text))
                    {
                        logProblemLbl.Text = "Account with similar login already exist.";
                        return;
                    }
                File.Create(FileSystem.FolderPath + "/" + EncryptionSystem.EncodePathFile(loginTb.Text + passwordTb.Text) + ".dat");
                File.SetAttributes(FileSystem.FolderPath + "/" + EncryptionSystem.EncodePathFile(loginTb.Text + passwordTb.Text) + ".dat", FileAttributes.Hidden);
                logInBtn_Click(sender, e);
            }
        }

        private void loginTb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                passwordTb.Focus();
        }

        private void passwordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logInBtn_Click(sender, e);
        }
    }
}
