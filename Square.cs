namespace VirtualKeywordLearning;

public class Square(double side) : Shape(side, 0)
{
    public override double FindArea()
    {
        return Math.Pow(side, 2);
    }
}