using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public  interface ICarServiceRepository
    {
        public List <CarService> GetAllNotDone();

        

        public bool GenerateXml(List <CarService> carServices);
    }
}
