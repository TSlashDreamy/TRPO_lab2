namespace lab2;

class Triangle
{
    private double side1;
    private double side2;
    private double side3;
    private double area;

    public event EventHandler AreaExceeds100;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
        area = 0;
    }

    public void CalculateArea()
    {
        // Розраховуємо площу трикутника за формулою Герона
        double s = (side1 + side2 + side3) / 2;
        double calcArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        area = calcArea;
    }

    public void CheckArea()
    {
        CalculateArea();
        if (area > 100)
        {
            // Виникнення події, якщо площа більша за 100
            OnAreaExceeds100(EventArgs.Empty);
            NullSides();
        }
    }

    public void NullSides()
    {
        // Замінюємо довжини сторін трикутника та площу на нуль
        side1 = 0;
        side2 = 0;
        side3 = 0;
        area = 0;
        Console.WriteLine("Довжини сторін трикутника та площу замінено на нуль");
    }

    protected virtual void OnAreaExceeds100(EventArgs e)
    {
        AreaExceeds100?.Invoke(this, e);
    }
}
