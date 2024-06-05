using Servicess;
using Models;
namespace Controllerss
{
    public class CarController
    {
        private CarServices carServices;

        public CarController()
        {
            this.carServices = new CarServices();
        }

        public string Insert()
        {
            return carServices.Insert();
        }

        public void GetAll()
        {
           List <Car>  lst = carServices.GetAll();
            foreach (Car c in lst)
            {
                Console.WriteLine(c);
            }
        }
    }
}
