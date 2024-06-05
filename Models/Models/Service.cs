using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Service
    {
        public static readonly string Insert = "INSERT INTO Service (Description) VALUES (@Description)";
        public static readonly string GetAll = "SELECT Id, Description FROM Service";

        public int Id { get; set; }
        public string Description { get; set; }

        public Service() { }

        public override string ToString()
        {
            return "Id: " + Id + "\nDescription: " + Description + "\n";
        }


    }
}
