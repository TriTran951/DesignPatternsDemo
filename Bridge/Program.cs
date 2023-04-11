using System;

// Abstraction
public abstract class Vehicle
{
    protected IEngine engine;

    public Vehicle(IEngine engine)
    {
        this.engine = engine;
    }

    public abstract void Drive();
    public abstract void Stop();
}

// Implementor
public interface IEngine
{
    void Start();
    void Stop();
}

// Concrete Implementor
public class PetrolEngine : IEngine
{
    public void Start()
    {
        Console.Write("Starting petrol engine");
    }

    public void Stop()
    {
        Console.Write("Stopping petrol engine");
    }
}

// Concrete Implementor
public class DieselEngine : IEngine
{
    public void Start()
    {
        Console.Write("Starting diesel engine");
    }

    public void Stop()
    {
        Console.Write("Stopping diesel engine");
    }
}

// Refined Abstraction
public class Car : Vehicle
{
    public Car(IEngine engine) : base(engine)
    {
    }

    public override void Drive()
    {
        Console.Write("Call method drive: ");
        engine.Start();

        Console.WriteLine(" &  Driving car");
    }

    public override void Stop()
    {
        Console.Write("Call method stop: ");
        engine.Stop();

        Console.WriteLine(" & Car stopped");
    }
}

// Refined Abstraction
public class Truck : Vehicle
{
    public Truck(IEngine engine) : base(engine)
    {
    }

    public override void Drive()
    {
        Console.Write("Call method drive: ");
        engine.Start();

        Console.WriteLine(" & Driving Truck");
    }

    public override void Stop()
    {

        Console.Write("Call method stop: ");
        engine.Stop ();

        Console.WriteLine(" & Truck stopped");
    }
}

// Client
public class Program
{
    public static void Main()
    {
   

        Console.WriteLine("Car with petrol engine: ");
        Console.WriteLine("----------------------------");

        Vehicle car = new Car(new PetrolEngine());
        car.Drive();

        car.Stop();

        Console.WriteLine("----------------------------");
    }
}
