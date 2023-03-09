using AbstractFactory.Fashion;
using AbstractFactory.Fashion.Dior;
using AbstractFactory.Fashion.Gucci;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            client.ClientMethod(new DiorFashion());
        }
    }
}