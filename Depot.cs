using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сервер
{
    public class Depot
    {
        public string ID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Responsible { get; set; }

        public Depot(string id, string number, string name, string responsible)
        {
            this.ID = id;
            this.Number = number;
            this.Name = name;
            this.Responsible = responsible;
        }
    }
}
