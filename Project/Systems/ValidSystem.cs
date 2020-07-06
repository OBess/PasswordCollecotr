using PasswordCollector.Unit;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordCollector.Systems
{
    class ValidSystem
    {
        public static bool IsNotEmpty(Label lbl, params string[] data)
        {
            foreach (string str in data)
                if (str.Length == 0) { lbl.Text = "Some field is empty"; return false; }
            return true;
        }

        public static void ClearFilter(List<Account> accounts, List<Account> filterAccounts)
        {
            filterAccounts.Clear();
            filterAccounts.AddRange(accounts);
        }
    }
}
