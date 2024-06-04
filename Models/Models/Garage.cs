using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Garage
    {
        List <Car> Cars { get; set; }

        public Garage( List <Car> cars)
        {
            Cars = cars;
        }


    }
}
