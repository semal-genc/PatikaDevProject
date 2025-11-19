internal class Program
{
    private static void Main(string[] args)
    {
        InputService input = new InputService();
        ShapeFactory factory = new ShapeFactory();

        string choice = input.GetShapeSelection();
        IShape? shape = factory.Create(choice);

        if (shape == null)
        {
            Console.WriteLine("Hatalı Seçim!");
            return;
        }
        shape.GetInputs();
        double area = shape.CalculateArea();

        Console.WriteLine($"Alan: {area}");
    }
}

public class InputService
{
    public string GetShapeSelection()
    {
        Console.Write("1. Daire \n2. Üçgen \n3. Kare \n4. Dikdörtgen \nAlanını hesaplamak istediğiniz şekli seçiniz (örn: 3): ");

        return Console.ReadLine()!;
    }
}

public class ShapeFactory
{
    public IShape? Create(string choice)
    {
        return choice switch
        {
            "1" => new Circle(),
            "2" => new Triangle(),
            "3" => new Square(),
            "4" => new Rectangle(),
            _ => null
        };
    }
}

public interface IShape
{
    void GetInputs();
    double CalculateArea();
}

public class Circle : IShape
{
    private double _radius;

    public void GetInputs()
    {
        Console.Write("Yarıçap: ");
        _radius = double.Parse(Console.ReadLine()!);
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }

}

public class Triangle : IShape
{
    private double _base;
    private double _height;

    public void GetInputs()
    {
        Console.Write("Taban: ");
        _base = double.Parse(Console.ReadLine()!);

        Console.Write("Yükseklik: ");
        _height = double.Parse(Console.ReadLine()!);
    }

    public double CalculateArea()
    {
        return (_base * _height) / 2;
    }
}

public class Square : IShape
{
    private double _side;
    public void GetInputs()
    {
        Console.Write("Kenar: ");
        _side = double.Parse(Console.ReadLine()!);
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}

public class Rectangle : IShape
{
    private double _short;
    private double _long;
    public void GetInputs()
    {
        Console.Write("Kısa Kenar: ");
        _short = double.Parse(Console.ReadLine()!);

        Console.Write("Uzun Kenar: ");
        _long = double.Parse(Console.ReadLine()!);
    }

    public double CalculateArea()
    {
        return _short * _long;
    }
}