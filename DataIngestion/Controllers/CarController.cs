using Models;
using Services;
namespace Controllers
{
    public class CarController
    {
        private CarService _service;

        public CarController()
        {
            _service = new CarService();
        }

        public bool Insert(List<Car> cars)
        {
            return _service.Insert(cars);
        }
    }
}
