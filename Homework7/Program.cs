class Rectangle
{

    public double width;
    public double height;


    public double GetArea()
    {
        return width * height;
    }

    public double GetPerimeter()
    {
        return 2 * (width + height);
    }


    static void Main()
    {
        Rectangle Ruby = new Rectangle();
        Ruby.width = 8;
        Ruby.height = 4;


        Rectangle Sapphire = new Rectangle();
        Sapphire.width = 9;
        Sapphire.height = 3;

        Console.WriteLine("Прямоугольник 1:");
        Console.WriteLine($"Ширина:   {Ruby.width}");
        Console.WriteLine($"Высота:   {Ruby.height}");
        Console.WriteLine($"Площадь:  {Ruby.GetArea()}");
        Console.WriteLine($"Периметр: {Ruby.GetPerimeter()}");

        Console.WriteLine();

        Console.WriteLine("Прямоугольник 2:");
        Console.WriteLine($"Ширина:   {Sapphire.width}");
        Console.WriteLine($"Высота:   {Sapphire.height}");
        Console.WriteLine($"Площадь:  {Sapphire.GetArea()}");
        Console.WriteLine($"Периметр: {Sapphire.GetPerimeter()}");
    }
}