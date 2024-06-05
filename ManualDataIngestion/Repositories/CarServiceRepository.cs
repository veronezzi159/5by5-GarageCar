using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Repositories
{
    public  class CarServiceRepository : ICarServiceRepository
    {
        private string Conn { get; set; }

        public CarServiceRepository()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog = Garage; User Id = sa; Password = SqlServer2019!; TrustServerCertificate = true;";
        }

        public CarService Insert(CarService carService)
        {
            int rows = 0;
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                rows = conn.Execute(CarService.Insert, carService);
            }
            if (rows == 0)
            {
                return null;
            }
            else
                return carService;
        }

        public int Update(int id)
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Execute(CarService.Update,new { Id = id });
            }
        }

        public List<CarService> GetAllNotDone()
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Query<CarService>(CarService.GetAllNotDone).ToList();
            }
        }
    }
}
