using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Client
    {
        public string ID { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Currensy { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        

        public Client(string id, string adress, string name, string age, string gender, string currensy, string phone, string company)
        {
            this.ID = id;
            this.Adress = adress;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Currensy = currensy;
            this.Phone = phone;
            this.Company = company;
        }
    }
}
