public class Square : Shape
{
    // Variables
    private double _side;

    // Constructors
    public Square(string input, double side) : base(input)
    {
        _side = side;
    }

    // Methods
    public override double getArea()
    {
        return _side * _side;
    }
}