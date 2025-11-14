using System.Dynamic;

public abstract class Shape
{
    // Variables
    private string _color;

    // Constructors
    public Shape(string input)
    {
        _color = input;
    }

    // Methods
    public string getColor()
    {
        return _color;
    }

    public void setColor(string input)
    {
        _color = input;
    }

    public abstract double getArea();
}