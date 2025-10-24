namespace _01_Ytkalkylator;
public class Circle : Shape
{
    public Circle(double radius) : base(radius, radius)
    {
    }

    public override double CalculateSurface()
    {
        return Width * Width * Math.PI;
    }

    public override string ToString()
    {
        return base.ToString("Circle");
    }
}
