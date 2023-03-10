using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BusObj : ICar
    {
        public string CreateVehicle()
        {
            return this.ToString();
        }
    }
}
