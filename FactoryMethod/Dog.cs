using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod
{
    class Dog: Animal
    {
        public override void sleep()
        {
            Console.WriteLine("Dog sleep");
        }
    }
}
