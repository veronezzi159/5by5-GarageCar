using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Models;
using Repositories;

namespace Servicess
{
    public  class CarServiceService
    {
        public ICarServiceRepository _carRepository;
        public CarServiceService()
        {
            _carRepository = new CarServiceRepository();
        }
        public CarService Insert(CarService carService)
        {
            return _carRepository.Insert(carService);
        }
        public int Update(int id)
        {
            int ne = _carRepository.Update(id);
            return ne;
        }
        public List<CarService> GetAllNotDone()
        {
            return _carRepository.GetAllNotDone();
        }
    }
}
