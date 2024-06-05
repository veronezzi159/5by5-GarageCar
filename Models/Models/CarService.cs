using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarService
    {
        public static readonly string Insert = "INSERT INTO ServiceCar (Car, Service, Status) VALUES (@CarPlate, @ServiceId, @Status)";
        public static readonly string Update = "UPDATE ServiceCar SET Status = 1 WHERE Id = @Id";
        public static readonly string GetAllNotDone = "SELECT SC.Id, SC.Car, sc.Service FROM ServiceCar as SC INNER JOIN Car as c ON (sc.Car = c.Plate) INNER JOIN [Service] AS s ON (sc.Service = s.Id) WHERE Status = 0";

        
        public int Id { get; set; }    
        public string Car { get; set; }

        public int Service { get; set; }

        public int Status { get; set; }    

        public CarService() 
        {
            Status  = 0;
        }

        public override string ToString()
        {
            if (Status == 0)
            {
                return "Id: " + Id + "\nCarPlate: " + Car + "\nServiceId: " + Service + "\nStatus: servico nao finalizado\n";
            }
            else
            {
                return "Id: " + Id + "\nCarPlate: " + Car + "\nServiceId: " + Service + "\nStatus: Finalizado\n";
            }
        }

    }
}
