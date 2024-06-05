using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Dapper;

namespace Repositories
{
    public interface ICarRepository
    {
        public List<Car> GetAllRed();

        public List<Car> GetSpecYear();

        public bool GenerateXml(List <Car> cars, int op);

    }
}
