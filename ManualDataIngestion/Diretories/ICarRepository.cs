using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Diretories
{
    public interface ICarRepository
    {
        public string Insert(Car car);

        public List <Car> GetAll();
        
    }
}
