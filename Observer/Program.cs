using System;
using System.Collections.Generic;

// Interface định nghĩa phương thức cập nhật cho các observers
public interface IObserver
{
    void Update();
}

// Lớp Subject định nghĩa phương thức để quản lý và thông báo cho các observers
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private int state;

    public int State
    {
        get { return state; }
        set
        {
            state = value;
            Notify(); // Gọi phương thức Notify khi trạng thái thay đổi
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}

// Lớp Observer1 triển khai giao diện IObserver
public class Observer1 : IObserver
{
    private Subject subject;

    public Observer1(Subject subject)
    {
        this.subject = subject;
    }

    public void Update()
    {
        Console.WriteLine("Observer 1: Trạng thái đã thay đổi thành " + subject.State);
    }
}

// Lớp Observer2 triển khai giao diện IObserver
public class Observer2 : IObserver
{
    private Subject subject;

    public Observer2(Subject subject)
    {
        this.subject = subject;
    }

    public void Update()
    {
        Console.WriteLine("Observer 2: Trạng thái đã thay đổi thành " + subject.State);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Subject subject = new Subject();

        // Tạo các observers
        Observer1 observer1 = new Observer1(subject);
        Observer2 observer2 = new Observer2(subject);

        // Đăng ký các observers với subject
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Thay đổi trạng thái của subject và thông báo cho các observers
        subject.State = 5;

        // Kết quả đầu ra sẽ là:
        // Observer 1: Trạng thái đã thay đổi thành 5
        // Observer 2: Trạng thái đã thay đổi thành 5

        // Hủy đăng ký một observer và thay đổi trạng thái
        subject.Detach(observer1);
        subject.State = 10;

        // Kết quả đầu ra sẽ là:
        // Observer 2: Trạng thái đã thay đổi thành 10
    }
}
