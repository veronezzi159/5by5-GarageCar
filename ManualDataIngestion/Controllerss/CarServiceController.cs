using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Servicess;


namespace Controllerss
{
    public  class CarServiceController
    {
        private CarServiceService _carServiceService;
        private CarServices _carService;
        private ServiceService ServiceService;

        public CarServiceController()
        {
            _carServiceService = new CarServiceService();
            _carService = new CarServices();
            ServiceService = new ServiceService();
        }

        public void Insert()
        {
            List<Service> ls = ServiceService.GetAll();
            Console.WriteLine("Servicos disponiveis: ");
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Digite o id do servico que deseja realizar");
            int id = 0;
            do
            {
                try
                {
                   id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!(ls.Any(s => s.Id == id)));
            List <Car> lc = _carService.GetAll();
            Console.WriteLine("Carros disponiveis: ");
            foreach (var item in lc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Digite a placa do carro que deseja realizar o servico");
            string car = "";
            do
            {
                try
                {
                    car = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!(lc.Any(c => c.Plate == car)));
            
            CarService cs = new CarService()
            {
                Car = car,
                Service = id
            };

            CarService cs1 = _carServiceService.Insert(cs);
            if (cs1 != null)
            {
                var service = ls.Where(s => s.Id == id);
                string desc = "";
                foreach (var item in service)
                {
                    desc = item.Description;
                }

                Console.WriteLine($"Servico de {desc} no carro de placa {car} inserido com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao inserir servico no carro");
            }


        }
        public void Update() 
        {
            var ls = _carServiceService.GetAllNotDone();
            Console.WriteLine("Servicos nao acabados");
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Digite o id do servico que deseja finalizar");
            int id = 0;
            do
            {
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!(ls.Any(s => s.Id == id)));
            int s = _carServiceService.Update(id);
            if (s == 1)
            {
                Console.WriteLine($"Servico de id {id} finalizado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao finalizar servico");
            }
        }

    }
}
