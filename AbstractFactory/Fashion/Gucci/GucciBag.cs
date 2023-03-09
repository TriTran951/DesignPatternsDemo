using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Fashion.Gucci
{
    internal class GucciBag: IBag
    {
        public string GetName()
        {
            return "Gucci bag";
        }

        public string GetModel()
        {
            return "This is Gucci bag";
        }
    }
}
