using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Emploee
    {
        public string ID { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Expereance { get; set; }
        public string Pay { get; set; }
        public string Position { get; set; }
        public string Time_per_week { get; set; }
        public string Salary { get; set; }
        public Emploee(string id, string adress, string name, string age, string gender, string expereance, string pay, string position, string time_per_week, string salary)
        {
            this.ID = id;
            this.Adress = adress;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Expereance = expereance;
            this.Pay = pay;
            this.Position = position;
            this.Time_per_week = time_per_week;
            this.Salary = salary;
        }
    }
}
