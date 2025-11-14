public class Rectangle : Shape
{
    // Variables
    private double _length;
    private double _width;

    // Constructors
    public Rectangle(string input, double length, double width) : base(input)
    {
        _length = length;
        _width = width;
    }

    // Methods
    public override double getArea()
    {
        return _length * _width;
    }
}