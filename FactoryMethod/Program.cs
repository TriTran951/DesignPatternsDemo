using FactoryMethod;
using System;
using System.Diagnostics;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello transportation app !");

            var truck = new TruckCreator();
            Console.WriteLine("{0}", truck.CreateVehicle());

            var bus = new BusCreator();
            Console.WriteLine("{0}", bus.CreateVehicle());
        }
    }
}