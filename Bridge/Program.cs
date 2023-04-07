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
        Console.WriteLine("Starting petrol engine");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping petrol engine");
    }
}

// Concrete Implementor
public class DieselEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Starting diesel engine");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping diesel engine");
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
        engine.Start();
        Console.WriteLine("Driving car...");
    }

    public override void Stop()
    {
        engine.Stop();
        Console.WriteLine("Car stopped.");
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
        engine.Start();
        Console.WriteLine("Driving truck...");
    }

    public override void Stop()
    {
        engine.Stop();
        Console.WriteLine("Truck stopped.");
    }
}

// Client
public class Program
{
    public static void Main()
    {
        Vehicle car = new Car(new PetrolEngine());
        car.Drive();
        car.Stop();

        Console.WriteLine("----------------------------");

        Vehicle truck = new Truck(new DieselEngine());
        truck.Drive();
        truck.Stop();


    }
}
