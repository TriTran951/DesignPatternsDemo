//Builder Interface: chỉ định các phương phương pháp để tạo các phần khác nhau Product object 
public interface IBuilder
{
    void BuildPartA();

    void BuildPartB();

    void BuildPartC();
}

//Concrete Builder: tuân theo Builder Interface cung cấp các triển khai cụ thể của từng bước
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public ConcreteBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._product = new Product();
    }


    public void BuildPartA()
    {
        this._product.Add("PartA1");
    }

    public void BuildPartB()
    {
        this._product.Add("PartB1");
    }

    public void BuildPartC()
    {
        this._product.Add("PartC1");
    }

    public Product GetProduct()
    {
        Product result = this._product;

        this.Reset();

        return result;
    }
}

//Product: Chỉ sử dụng Builder Pattern khi sản phẩm có nhiều loại và trở nên phức tạp và cần có tỉnh mở rộng.
//Vì đôi khi Concrete builder khác nhau có thể tạo ra những product khác nhau và không liên quan đến nhau. 
public class Product
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        this._parts.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < this._parts.Count; i++)
        {
            str += this._parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}

//Director: Director chịu trách nhiệm thực hiện các bước build theo một trình tự xác định cụ thể
//Class Director là tùy chọn để có Client có thể kiểm soát trực tiếp quá trình.
public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMinimalViableProduct()
    {
        this._builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildPartA();
        this._builder.BuildPartB();
        this._builder.BuildPartC();
    }
}

class Program
{
    //Main: Client code tạo một builder object, chuyển cho Director,và bắt đầu chạy, kết quả sẽ được truy xuất từ builder object
    static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
    }
}