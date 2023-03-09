using FactoryMethod;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Run();
            dog.sleep();
        }
    }
}