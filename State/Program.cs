public interface IOrderState
{
    void ProcessOrder(Order order);
    string Status { get; }
}

public class NewOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        // xử lý đơn hàng mới ở đây
        order.State = new ShippedOrderState();
    }

    public string Status
    {
        get { return "New Order"; }
    }
}

public class ShippedOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        // xử lý đơn hàng đã được gửi đi ở đây
        order.State = new DeliveredOrderState();
    }

    public string Status
    {
        get { return "Shipped"; }
    }
}

public class DeliveredOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        // xử lý đơn hàng đã được giao đến ở đây
        order.State = new ClosedOrderState();
    }

    public string Status
    {
        get { return "Delivered"; }
    }
}

public class ClosedOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        // không làm gì cả, vì đơn hàng đã đóng
    }

    public string Status
    {
        get { return "Closed"; }
    }
}

public class Order
{
    public IOrderState State { get; set; }

    public Order()
    {
        State = new NewOrderState();
    }

    public void Process()
    {
        State.ProcessOrder(this);
    }

    public string Status
    {
        get { return State.Status; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Console.WriteLine(order.Status); // "New Order"

        order.Process();
        Console.WriteLine(order.Status); // "Shipped"

        order.Process();
        Console.WriteLine(order.Status); // "Delivered"

        order.Process();
        Console.WriteLine(order.Status); // "Closed"

    }
}
