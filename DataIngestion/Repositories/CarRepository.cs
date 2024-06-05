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
            //_connectionString = ConfigurationManager.ConnectionStrings["ConnnectionString"].ConnectionString;
            _connectionString = "Data Source = 127.0.0.1; Initial Catalog = Garage; User Id = sa; Password = SqlServer2019!; TrustServerCertificate = true;";
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
