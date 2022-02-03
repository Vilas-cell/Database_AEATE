using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class User_auth
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User_auth(string id, string login, string password)
        {
            this.ID = id;
            this.Login = login;
            this.Password = password;

        }
    }
}
