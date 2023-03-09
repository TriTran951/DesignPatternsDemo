using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fashion.Dior
{
    internal class DiorFashion: IFashion
    {
        public IBag CreateBag()
        {
            return new DiorBag();
        }

        public IDress CreateDress()
        {
            return new DiorDress();
        }
    }
}
