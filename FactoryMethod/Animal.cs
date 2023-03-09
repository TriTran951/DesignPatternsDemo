using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Animal
    {
        public void Run() 
        {
            Console.WriteLine("Animal run");
        }
        public abstract void sleep();
    }
}
