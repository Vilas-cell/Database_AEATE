using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class User
    {
        public string ID { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public User(string id, string adress, string name, string age, string gender)
        {
            this.ID = id;
            this.Adress = adress;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }
    }
}
