public class Circle : Shape
{
    // Variables
    private double _radius;

    // Constructors
    public Circle(string input, double radius) : base(input)
    {
        _radius = radius;
    }

    // Methods
    public override double getArea()
    {
        return 2 * Math.PI * _radius;
    }
}