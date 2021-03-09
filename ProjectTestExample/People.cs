using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestExample
{
    public class People
    {

        private string login;
        private string pass;
        private string email;
        private long phone;

        public People(string login, string pass, string email, long phone)
        {
            this.login = login;
            this.pass = pass;
            this.email = email;
            this.phone = phone;

        }

        public string Login { get => login; set => login = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Email { get => email; set => email = value; }
        public long Phone { get => phone; set => phone = value; }

    }
}
