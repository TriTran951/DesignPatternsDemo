using System;

// Component interface
public interface IComponent
{
    void Operation();
}

// Leaf class
public class Leaf : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Leaf operation.");
    }
}

// Composite class
public class Composite : IComponent
{
    private List<IComponent> _children = new List<IComponent>();

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public void Operation()
    {
        Console.WriteLine("Composite operation.");
        foreach (IComponent component in _children)
        {
            component.Operation();
        }
    }
}

// Client code
class Client
{
    static void Main(string[] args)
    {
        // Create leaf components
        Leaf leaf1 = new Leaf();
        Leaf leaf2 = new Leaf();
        Leaf leaf3 = new Leaf();

        // Create composite components
        Composite composite1 = new Composite();
        Composite composite2 = new Composite();

        // Add leaf components to composite1
        composite1.Add(leaf1);
        composite1.Add(leaf2);

        // Add composite1 and leaf3 to composite2
        composite2.Add(composite1);
        composite2.Add(leaf3);

        // Call Operation() on composite2
        composite2.Operation();
    }
}
