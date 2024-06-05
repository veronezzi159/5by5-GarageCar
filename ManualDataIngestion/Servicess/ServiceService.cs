using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Models;

namespace Servicess
{
    public class ServiceService
    {
        private IServiceRepository _serviceRepository;

        public ServiceService()
        {
            _serviceRepository = new ServiceRepository();
        }

        public Service Insert()
        {
            Service service = CreateService();
            return _serviceRepository.Insert(service);
        }

        public List<Service> GetAll()
        {
            return _serviceRepository.GetAll();
        }
        private Service CreateService()
        {
            string description = "";
            do
            {
                try
                {
                    Console.WriteLine("Digite a descricao do servico");
                    description = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (description == "");
            
            
            Service service = new Service()
            {
                Description = description
            };
            return service;
        }
    }
}
