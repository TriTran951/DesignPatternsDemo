using System;

// Abstract handler
abstract class Handler
{
    protected Handler successor;

    public void SetNextSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}

// Concrete handler 1
class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
        {
            Console.WriteLine($"{GetType().Name} handles the request {request}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}

// Concrete handler 2
class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine($"{GetType().Name} handles the request {request}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}

// Concrete handler 3
class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.WriteLine($"{GetType().Name} handles the request {request}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}

class Client
{
    public void Main()
    {
        // Tạo các handler
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();
        Handler handler3 = new ConcreteHandler3();

        // Thiết lập mối quan hệ liên kết
        handler1.SetNextSuccessor(handler2);
        handler2.SetNextSuccessor(handler3);

        // Gửi yêu cầu cho handler đầu tiên trong chuỗi
        handler1.HandleRequest(5);
        handler1.HandleRequest(15);
        handler1.HandleRequest(25);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.Main();
    }
}
