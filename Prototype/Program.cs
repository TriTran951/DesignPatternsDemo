using System;
using System.Net;

public class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    // Sao chép đối tượng
    public object Clone()
    {
        return new Person
        {
            Name = this.Name,
            Age = this.Age,
            Address = this.Address.Clone() as Address
        };
    }
}


// Đối tượng phụ trợ
public class Address : ICloneable
{
    public string Street { get; set; }
    public string City { get; set; }

    // Sao chép đối tượng
    public object Clone()
    {
        return new Address
        {
            Street = this.Street,
            City = this.City
        };
    }
}

public class Program
{
    public static void Main()
    {
        var person1 = new Person
        {
            Name = "John",
            Age = 30,
            Address = new Address
            {
                Street = "123 Main St",
                City = "New York"
            }
        };

        // Sao chép đối tượng person1 để tạo person2
        var person2 = person1.Clone() as Person;

        // Thay đổi giá trị của person2
        person2.Name = "Jane";
        person2.Age = 25;
        person2.Address.Street = "456 Oak St";

        // In thông tin của person1 và person2
        Console.WriteLine($"Person 1: {person1.Name}, {person1.Age}, {person1.Address.Street}, {person1.Address.City}");
        Console.WriteLine($"Person 2: {person2.Name}, {person2.Age}, {person2.Address.Street}, {person2.Address.City}");
    }
}