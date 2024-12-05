namespace VirtualKeywordLearning;

public class Rectangle(double length, double height) : Shape(length, height)
{
    public override double FindArea()
    {
        return length * height;
    }
}