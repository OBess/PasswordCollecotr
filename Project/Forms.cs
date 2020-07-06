using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PasswordCollector.Systems;
using PasswordCollector.Unit;

namespace PasswordCollector
{
    class Forms
    {
        public static Panel FormUnit(FlowLayoutPanel listFlp, string[] data, List<Account> accounts, List<Account> filterAccounts, int num)
        {
            Panel panel = new Panel();
            Label webSitelbl = new Label();
            Label loginlbl = new Label();
            Label passwordLbl = new Label();
            Button change = new Button();
            Button remove = new Button();

            panel.BorderStyle = BorderStyle.FixedSingle;
            change.FlatStyle = FlatStyle.Flat;
            change.FlatAppearance.BorderColor = Color.Black;
            change.FlatAppearance.BorderSize = 1;
            remove.FlatStyle = FlatStyle.Flat;
            remove.FlatAppearance.BorderColor = Color.Black;
            remove.FlatAppearance.BorderSize = 1;

            webSitelbl.Text = "Web Site   " + data[0];
            loginlbl.Text = "Login      " + data[1];
            passwordLbl.Text = "Password   ";
            foreach (var c in data[2]) passwordLbl.Text += '*';
            change.Text = "Change";
            remove.Text = "Delete";

            panel.SetBounds(0, 0, listFlp.Width - 10, 86);
            webSitelbl.SetBounds(21, 12, panel.Width - 101 - 25, 14);
            loginlbl.SetBounds(21, 37, panel.Width - 101 - 25, 14);
            passwordLbl.SetBounds(21, 64, panel.Width - 101 - 25, 14);
            change.SetBounds(panel.Width - 101, 12, 76, 23);
            remove.SetBounds(panel.Width - 101, 55, 76, 23);

            panel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            webSitelbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            loginlbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            passwordLbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            change.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            remove.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            webSitelbl.Click += delegate { ShowToolTipWhenClick(accounts[num].WebSite, webSitelbl); };
            loginlbl.Click += delegate { ShowToolTipWhenClick(accounts[num].Login, loginlbl); };
            passwordLbl.Click += delegate { ShowToolTipWhenClick(accounts[num].Password, passwordLbl); };
            change.Click += delegate {
                string[] data1 = { "Web Site", "Login", "Password" };
                if (Forms.InputBox("Change data of account", "Enter your data (you can fill in not everything)", ref data1) == DialogResult.OK)
                {
                    accounts[num].WebSite = data1[0] == "" || data1[0] == "Web Site" ? accounts[num].WebSite : data1[0];
                    accounts[num].Login = data1[1] == "" || data1[1] == "Login" ? accounts[num].Login : data1[1];
                    string newPass = "";
                    if (data1[2] != "" && data1[2] != "Password")
                    {
                        accounts[num].Password = data1[2];
                        foreach (var c in data1[2]) newPass += '*';
                        passwordLbl.Text = newPass;
                    }
                    ValidSystem.ClearFilter(accounts, filterAccounts);
                    Fill(listFlp, accounts, filterAccounts);
                }
            };
            remove.Click += delegate {
                if (MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    accounts.RemoveAt(num);
                    ValidSystem.ClearFilter(accounts, filterAccounts);
                    Fill(listFlp, accounts, filterAccounts);
                }
            };

            panel.Controls.AddRange(new Control[] { webSitelbl, loginlbl, passwordLbl, change, remove });
            return panel;
        }
        public static DialogResult InputBox(string title, string promptText, ref string[] value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox siteTextBox = new TextBox();
            TextBox loginTextBox = new TextBox();
            TextBox passwordTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            siteTextBox.Text = value[0];
            loginTextBox.Text = value[1];
            passwordTextBox.Text = value[2];

            siteTextBox.ForeColor = Color.Gray;
            loginTextBox.ForeColor = Color.Gray;
            passwordTextBox.ForeColor = Color.Gray;

            siteTextBox.Enter += delegate { siteTextBox.Text = null; siteTextBox.ForeColor = Color.Black; };
            loginTextBox.Enter += delegate { loginTextBox.Text = null; loginTextBox.ForeColor = Color.Black; };
            passwordTextBox.Enter += delegate { passwordTextBox.Text = null; passwordTextBox.ForeColor = Color.Black; };

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            siteTextBox.SetBounds(12, 36, 372, 20);
            loginTextBox.SetBounds(12, 62, 372, 20);
            passwordTextBox.SetBounds(12, 86, 372, 20);
            buttonOk.SetBounds(228, 115, 75, 23);
            buttonCancel.SetBounds(309, 115, 75, 23);

            label.AutoSize = true;
            siteTextBox.Anchor = loginTextBox.Anchor | AnchorStyles.Right;
            loginTextBox.Anchor = loginTextBox.Anchor | AnchorStyles.Right;
            passwordTextBox.Anchor = loginTextBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            siteTextBox.KeyDown += KeyDown;
            loginTextBox.KeyDown += KeyDown;
            passwordTextBox.KeyDown += KeyDown;

            siteTextBox.MaxLength = 34;
            loginTextBox.MaxLength = 34;
            passwordTextBox.MaxLength = 34;

            form.ClientSize = new Size(396, 150);
            form.Controls.AddRange(new Control[] { label, siteTextBox, loginTextBox, passwordTextBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value[0] = siteTextBox.Text;
            value[1] = loginTextBox.Text;
            value[2] = passwordTextBox.Text;
            return dialogResult;
        }

        public static DialogResult ChangeInfo(ref string[] value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox loginTextBox = new TextBox();
            TextBox passwordTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            bool cancel = false;

            form.Text = "Change account`s info";
            label.Text = "Enter your data";
            loginTextBox.Text = value[0];
            passwordTextBox.Text = value[1];

            loginTextBox.ForeColor = Color.Gray;
            passwordTextBox.ForeColor = Color.Gray;

            loginTextBox.Enter += delegate { loginTextBox.Text = null; loginTextBox.ForeColor = Color.Black; };
            passwordTextBox.Enter += delegate { passwordTextBox.Text = null; passwordTextBox.ForeColor = Color.Black; };

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            loginTextBox.SetBounds(12, 36, 372, 20);
            passwordTextBox.SetBounds(12, 62, 372, 20);
            buttonOk.SetBounds(228, 86, 75, 23);
            buttonCancel.SetBounds(309, 86, 75, 23);

            label.AutoSize = true;
            loginTextBox.Anchor = loginTextBox.Anchor | AnchorStyles.Right;
            passwordTextBox.Anchor = loginTextBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            loginTextBox.KeyDown += KeyDown;
            passwordTextBox.KeyDown += KeyDown;
            buttonOk.Click += delegate {
                if (MessageBox.Show("Are you sure you want to Change", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                    cancel = true;
            };

            loginTextBox.MaxLength = 34;
            passwordTextBox.MaxLength = 34;

            passwordTextBox.PasswordChar = '*';

            form.ClientSize = new Size(396, 150);
            form.Controls.AddRange(new Control[] { label, loginTextBox, passwordTextBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (cancel) return DialogResult.Cancel;
            value[0] = loginTextBox.Text;
            value[1] = passwordTextBox.Text;
            return dialogResult;
        }

        public static void Fill(FlowLayoutPanel listFlp, List<Account> accounts, List<Account> filterAccounts)
        {
            listFlp.Controls.Clear();
            if (filterAccounts == null || filterAccounts.Count == 0) return;
            int i = 0;
            foreach (Account account in filterAccounts)
            {
                listFlp.Controls.Add(Forms.FormUnit(listFlp, new string[] { account.WebSite, account.Login, account.Password }, accounts, filterAccounts, i));
                i++;
            }
        }

        private static void ShowToolTipWhenClick(string text, Control control)
        {
            Clipboard.SetText(text);
            int durationMilliseconds = 1100;
            ToolTip toolTip = new ToolTip();
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.Show("Copied to clipboard", control, durationMilliseconds);
        }

        private static void KeyDown(object sender, KeyEventArgs e)
        {
            TextBox l = sender as TextBox;
            if (e.KeyCode == Keys.Down) l.Parent.Controls[l.Parent.Controls.IndexOf(l) + 1].Focus();
            if (e.KeyCode == Keys.Up) l.Parent.Controls[l.Parent.Controls.IndexOf(l) - 1].Focus();
        }
    }
}
