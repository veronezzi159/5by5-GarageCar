using Repositories;
using Models;
namespace Services
{
    public class CarService
    {
        private ICarRepository carRepository;
        public CarService()
        {
            this.carRepository = new CarRepository();   
        }
        public List<Car> GetAllRed()
        {
            return carRepository.GetAllRed();
        }

        public List<Car> GetSpecYear()
        {
            return carRepository.GetSpecYear();
        }
        public bool GenerateXml(List <Car> cars, int op)
        {
            return carRepository.GenerateXml(cars, op);
        }

    }
}
