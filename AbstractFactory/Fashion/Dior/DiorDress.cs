using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Fashion.Dior
{
    internal class DiorDress: IDress
    {
        public string GetName()
        {
            return "Dior Dress";
        }

        public string GetModel()
        {
            return "This is Dior dress";
        }
    }
}
