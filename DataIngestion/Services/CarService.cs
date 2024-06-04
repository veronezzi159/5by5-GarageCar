using Models;
using Repositories;
namespace Services
{
    public class CarService
    {
        private CarRepository _repository;

        public CarService()
        {
            _repository = new CarRepository();
        }

        public bool Insert(List<Car> cars)
        {
            return _repository.Insert(cars);
        }
    }
}
