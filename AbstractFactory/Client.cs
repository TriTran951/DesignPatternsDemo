using AbstractFactory.Fashion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Client
    {
        public void ClientMethod(IFashion factory) 
        {
            var bag = factory.CreateBag();
            var dress = factory.CreateDress();

            Console.WriteLine("Abstract factory demo:");
            Console.WriteLine("**********");

            Console.WriteLine(bag.GetName());
            Console.WriteLine(dress.GetName());

            Console.WriteLine("**********");
        }
    }
}
