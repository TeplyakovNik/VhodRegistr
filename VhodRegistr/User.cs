using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VhodRegistr
{
    internal class User
    {
        public String name;
        public String login;
        public Boolean sex;
        public String password;
        public String passwordDup;
        public User(string name, string login, bool sex, string password, string passwordDup)
        {
            this.name = name;
            this.login = login;
            this.sex = sex;
            this.password = password;
            this.passwordDup = passwordDup;
        }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
