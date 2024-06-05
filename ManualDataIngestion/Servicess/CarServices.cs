
using Repositories;
using Models;
namespace Servicess
{
    public class CarServices
    {
        private ICarRepository carRepository;

        public CarServices()
        {
            this.carRepository = new CarRepository();
        }

        public string Insert()
        {
            Car car = CreateCar();
            return carRepository.Insert(car);
        }

        public List <Car> GetAll()
        {
            return carRepository.GetAll();
        }

        private Car CreateCar()
        {
            string plate;
            do
            {
                Console.WriteLine("Digite a placa do veiculo( Modelo : XXX-0000)");
                plate = Console.ReadLine();
            } while (plate.Length !=8);
            Console.WriteLine("Digite o nome do veiculo");
            string name = Console.ReadLine();

            int ModelYear;
            int ManufactureYear;
            do
            {
                Console.WriteLine("Digite o ano de fabricacao do veiculo");
                ManufactureYear = int.Parse(Console.ReadLine());
                Console.WriteLine("O modelo do veiculo e do mesmo ano? ou do ano seguinte? 1 - mesmo ano, 2 - ano seguinte");
                int op = 0;
                do
                {
                     op = int.Parse(Console.ReadLine());
                } while (op < 1 || op > 2);
                if (op == 1)
                {
                    ModelYear = ManufactureYear;
                }
                else
                {
                    ModelYear = ManufactureYear + 1;
                }
                if (ModelYear > DateTime.Now.Year || ManufactureYear < 1886)
                {
                    Console.WriteLine("Ano de fabricacao invalido");
                }
            } while (ManufactureYear < 1886 || ManufactureYear > DateTime.Now.Year);
            string Color;
            Console.WriteLine("Digite a cor do veiculo");
            Color = Console.ReadLine();
            
            return new Car()
            {
                Plate = plate,
                Name = name,
                ModelYear = ModelYear,
                ManufactureYear = ManufactureYear,
                Color = Color
            };
        }
    }
}
