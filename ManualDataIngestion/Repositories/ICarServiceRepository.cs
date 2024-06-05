using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public interface ICarServiceRepository
    {
        public CarService Insert(CarService carService);

        public int Update(int id);

        public List<CarService> GetAllNotDone();
    }
}
