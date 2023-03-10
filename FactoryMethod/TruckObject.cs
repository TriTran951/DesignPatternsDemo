using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TruckObj : ICar
    {
        public string CreateVehicle()
        {
            return this.ToString();
        }
    }
}
