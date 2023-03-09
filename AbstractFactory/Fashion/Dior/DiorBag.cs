using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Fashion.Dior
{
    internal class DiorBag: IBag
    {
        public string GetName()
        {
            return "Dior Bag";
        }

        public string GetModel()
        {
            return "This is Dior Bag";
        }
    }
}
