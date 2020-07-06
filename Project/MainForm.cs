using PasswordCollector.Systems;
using PasswordCollector.Unit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PasswordCollector
{
    public partial class MainForm : Form
    {
        private LoginWindow loginW;
        private string path;

        private List<Account> accounts;
        private List<Account> filterAccounts;

        public MainForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            FileSystem.DirectoryIsExist(FileSystem.FolderPath);
            loginW = new LoginWindow(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            loginW.ShowDialog();
        }

        public void Login(string login, string path)
        {
            accountSddb.Text = login;
            this.path = path;
            DecodeAll();
            filterAccounts = new List<Account>();
            if(accounts != null && accounts.Count != 0) filterAccounts.AddRange(accounts);
            Forms.Fill(listFlp, accounts, filterAccounts);
        }

        private void EncodeAll()
        {
            if (accounts == null) return;
            foreach (Account account in accounts)
            {
                account.WebSite = EncryptionSystem.Encode(account.WebSite);
                account.Login = EncryptionSystem.Encode(account.Login);
                account.Password = EncryptionSystem.Encode(account.Password);
            }
            FileSystem.BinarySerialize(accounts, path);
            File.SetAttributes(path, FileAttributes.Hidden);
        }

        private void DecodeAll()
        {
            accounts = FileSystem.BinaryDeserialize(path) as List<Account>;
            if (accounts == null) return;
            foreach (Account account in accounts)
            {
                account.WebSite = EncryptionSystem.Decode(account.WebSite);
                account.Login = EncryptionSystem.Decode(account.Login);
                account.Password = EncryptionSystem.Decode(account.Password);
            }
        }

        private void logOutTsmi_Click(object sender, EventArgs e)
        {
            EncodeAll();
            accounts = null;
            filterAccounts = null;
            path = "";
            listFlp.Controls.Clear();
            accountSddb.Text = "Account";
            searchTb.Text = "";
            this.Hide();
            loginW.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (accounts == null) accounts = new List<Account>();
            string[] data = { "Web Site", "Login", "Password" };
            if (Forms.InputBox("Create new account", "Enter your data", ref data) == DialogResult.OK)
            {
                accounts.Add(new Account(data[0], data[1], data[2]));
                ValidSystem.ClearFilter(accounts, filterAccounts);
                Forms.Fill(listFlp, accounts, filterAccounts);
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Forms.Fill(listFlp, accounts, filterAccounts);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncodeAll();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (accounts == null || accounts.Count == 0) return;
            filterAccounts.Clear();
            if (searchTb.Text == "")
                filterAccounts.AddRange(accounts);
            else
            {
                foreach(Account account in accounts)
                    if (account.WebSite.Contains(searchTb.Text) || account.Login.Contains(searchTb.Text))
                        filterAccounts.Add(account);
            }
            Forms.Fill(listFlp, accounts, filterAccounts);
        }

        private void settingsTsmi_Click(object sender, EventArgs e)
        {
            string[] data = { "Login", "Password" };
            if(Forms.ChangeInfo(ref data) == DialogResult.OK)
            {
                string oldLog = accountSddb.Text;
                if (data[0] != "" || data[0] != "Login")
                    accountSddb.Text = data[0];
                else
                    data[0] = accountSddb.Text;
                if(data[1] != "" || data[1] != "Password")
                {
                    File.Delete(path);
                    path = FileSystem.FolderPath + "/" + EncryptionSystem.EncodePathFile(data[0] + data[1]) + ".dat";
                }
                else
                    foreach(var file in Directory.GetFiles(FileSystem.FolderPath))
                        if (EncryptionSystem.EncodePathFile(file).Contains(oldLog))
                        {
                            File.Delete(path);
                            path = file.Replace(oldLog, data[0]);
                        }
            }
        }
    }
}
