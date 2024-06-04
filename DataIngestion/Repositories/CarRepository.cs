using Models;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Dapper;
namespace Repositories
{
    public class CarRepository
    {
        private string _connectionString;

        public CarRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }
        public bool Insert(List <Car> cars)
        {
            int rows = 0;
           using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();                
                rows = connection.Execute(Car.Insert, cars);
                connection.Close();
           }
           if (rows == 0) return false;
           return true;

        }
    }
}
