using Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        private string Conn;
        public CarRepository()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog = Garage; User Id = sa; Password = SqlServer2019!; TrustServerCertificate = true;";
        }

        public List<Car> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Query<Car>(Car.GetAll).ToList();
            }
        }

        public string Insert(Car c)
        {
           using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                conn.Execute(Car.Insert,c);
                return $"{c.Plate}";
            }
        }
    }
}
