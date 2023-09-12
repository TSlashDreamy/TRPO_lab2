using lab2;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(20, 22, 25);
        triangle.AreaExceeds100 += Triangle_AreaExceeds100;
        triangle.CheckArea();
    }

    private static void Triangle_AreaExceeds100(object sender, EventArgs e)
    {
        Console.WriteLine("Площа трикутника перевищує 100.");
    }
}
