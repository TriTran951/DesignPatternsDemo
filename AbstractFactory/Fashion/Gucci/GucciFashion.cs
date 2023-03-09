using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fashion.Gucci
{
    internal class GucciFashion : IFashion
    {
        public IBag CreateBag()
        {
            return new GucciBag();
        }

        public IDress CreateDress()
        {
            return new GucciDress();
        }
    }
}
