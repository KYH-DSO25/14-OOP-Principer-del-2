namespace _01_Ytkalkylator;
internal class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    public override double CalculateSurface()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return base.ToString("Rectangle");
    }
}
