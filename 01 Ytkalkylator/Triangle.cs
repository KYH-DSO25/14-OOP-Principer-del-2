namespace _01_Ytkalkylator;
public class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height)
    {
    }

    public override double CalculateSurface()
    {
        return (Height * Width) / 2;
    }

    public override string ToString()
    {
        return base.ToString("Triangle");
    }
}
