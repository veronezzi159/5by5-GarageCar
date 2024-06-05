using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicess;
using Models;

namespace Controllerss
{
    public class ServiceController
    {
        private ServiceService _serviceService;

        public ServiceController()
        {
            _serviceService = new ServiceService();
        }

        public void Insert()
        {
           Service s1 = _serviceService.Insert();
            if (s1 != null)
            {
                Console.WriteLine($"Servico de {s1.Description} inserido com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao inserir servico");
            }
            
        }

        public void GetAll()
        {
            List <Service> lst = _serviceService.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
