namespace VirtualKeywordLearning;

public class Circle(double radius) : Shape(radius, 0)
{
    public override double FindArea()
    {
        return PI * Math.Pow(radius, 2);
    }
}