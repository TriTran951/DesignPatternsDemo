using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TruckCreator : Transportor
    {
        public override ICar CreateCar()
        {
            return new TruckObj();
        }
    }
}
