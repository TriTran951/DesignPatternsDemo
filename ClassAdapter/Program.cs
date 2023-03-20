public interface ExistingClass
{
    void Request();
}

public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request from Adaptee");
    }
}

public class ClassAdapter : Adaptee, ExistingClass
{
    public void Request()
    {
        base.SpecificRequest();
    }
}


public class Client
{
    static void Main()
    {
        ExistingClass target = new ClassAdapter();
        target.Request();
    }
}