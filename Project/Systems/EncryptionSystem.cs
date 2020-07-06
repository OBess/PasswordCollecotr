using System;

namespace PasswordCollector.Systems
{
    class EncryptionSystem
    {
        public static int EncodeCode(int n) => (n + 3) * 2;

        public static int DecodeCode(int n) => n / 2 - 3;
        public static string EncodePathFile(string path)
        {
            string newStr = "";
            foreach (char c in path) newStr += ((int)c).ToString();
            char[] res = newStr.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }
        public static string DecodePathFile(string path)
        {
            char[] res = path.ToCharArray();
            Array.Reverse(res);
            string newStr = "";
            foreach (char c in res) newStr += ((int)c).ToString();
            return newStr;
        }

        public static string Encode(string str)
        {
            string newStr = "";
            foreach(char c in str)
                newStr += (char)EncodeCode(c);
            char[] res = newStr.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }

        public static string Decode(string str)
        {
            char[] res = str.ToCharArray();
            Array.Reverse(res);
            string newStr = "";
            foreach (char c in res)
                newStr += (char)DecodeCode(c);
            return newStr;
        }
    }
}
