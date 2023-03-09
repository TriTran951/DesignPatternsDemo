using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Fashion
{
    internal interface IFashion
    {
        IBag CreateBag();

        IDress CreateDress();
    }
}
