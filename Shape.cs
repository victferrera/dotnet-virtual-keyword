namespace VirtualKeywordLearning;

public class Shape
{
    protected double PI = Math.PI;
    protected double _x, _y;

    public Shape(double x, double y)
    {
        _x = x;
        _y = y;
    }
    
    public virtual double FindArea()
    {
        return _x * _y;
    }
}