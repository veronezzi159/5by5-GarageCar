using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Dapper;
using Microsoft.Data.SqlClient; 

namespace Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private string Conn { get; set; }
        public ServiceRepository()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog = Garage; User Id = sa; Password = SqlServer2019!; TrustServerCertificate = true;";
        }

        public Service Insert(Service service)
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                conn.Execute(Service.Insert, service);
            }
            if (service == null)
            {
                return null;
            }else
                return service;
        }

        public List<Service> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(Conn))
            {
                conn.Open();
                return conn.Query<Service>(Service.GetAll).ToList();

            }
        }
    }
    
}
