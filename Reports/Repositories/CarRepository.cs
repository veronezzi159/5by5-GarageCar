using Microsoft.Data.SqlClient;
using Models;
using Dapper;
using System.Xml.Linq;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        private string Conn;
        public CarRepository()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog = Garage; User Id = sa; Password = SqlServer2019!; TrustServerCertificate = true;";
        }

        private void VerifyPath(string path1, string file1)
        {
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
            if (!File.Exists(path1 + file1))
            {
                File.Create(path1 + file1).Close();
            }
        }

        public bool GenerateXml(List<Car> cars, int op)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\DadosGarage\\";
            string file;
            if (op == 1)
                file =  "RedCars.xml";
            else if (op == 2)
                file = "SpecYearCars.xml";
            else
                file = null;
            

            VerifyPath(path, file);

            if (cars.Count == 0)
            {
                return false;
            }
            else
            {
                var car = new XElement("root",
                  from c in cars
                  select new XElement("Car",
                      new XElement("Plate", c.Plate),
                      new XElement("Name", c.Name),
                      new XElement("ModelYear", c.ModelYear),
                      new XElement("ManufactureYear", c.ManufactureYear),
                      new XElement("Color", c.Color)
                  )); 
                
                StreamWriter sw = new StreamWriter(path + file);
                sw.Write(car);
                sw.Close();
                return true;
            }

            throw new NotImplementedException();
        }

        public List<Car> GetAllRed()
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Query<Car>(Car.QueryRed).ToList();
            }
        }

        public List<Car> GetSpecYear()
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Query<Car>(Car.QueryRed).ToList();
            }
        }
    }
}
