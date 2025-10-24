namespace _01_Ytkalkylator;
public abstract class Shape
{
    private double width;
    private double height;

    public Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width must be greater than zero!");
            }
            width = value;
        }
    }


    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero!");
            height = value;
        }
    }

    public abstract double CalculateSurface();

    public string ToString(string type)
    {
        return string.Format("{0} -> Width: {1}, Height: {2}, Surface: {3}",
            type, Width, Height, CalculateSurface());
    }

}
