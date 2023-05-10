using System;

// Subject interface
public interface ICarService
{
    void GetCarDetails();
}

// Real Subject
public class CarService : ICarService
{
    public void GetCarDetails()
    {
        Console.WriteLine("Fetching car details...");
    }
}

// Proxy
public class CarServiceProxy : ICarService
{
    private readonly string _username;
    private readonly string _password;
    private CarService _carService;

    public CarServiceProxy(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public void GetCarDetails()
    {
        if (Authenticate())
        {
            if (_carService == null)
            {
                _carService = new CarService();
            }

            _carService.GetCarDetails();
        }
        else
        {
            Console.WriteLine("Authentication failed. Access denied.");
        }
    }

    private bool Authenticate()
    {
        // Perform authentication logic here, e.g. check credentials against database
        return (_username == "admin" && _password == "password");
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        // Proxy is used to get car details
        ICarService carServiceProxy = new CarServiceProxy("admin", "password");
        carServiceProxy.GetCarDetails();

        // Proxy is used again to get car details, but authentication will fail this time
        carServiceProxy = new CarServiceProxy("invalid", "password");
        carServiceProxy.GetCarDetails();
    }
}
