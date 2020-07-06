using System;
using System.Runtime.Serialization;

namespace PasswordCollector.Unit
{
    [DataContract(IsReference = true)]
    [Serializable]
    class Account
    {
        [DataMember]public string WebSite { get; set; }
        [DataMember]public string Login { get; set; }
        [DataMember]public string Password { get; set; }

        public Account(string webSite, string login, string pasword)
        {
            WebSite = webSite;
            Login = login;
            Password = pasword;
        }
    }
}
