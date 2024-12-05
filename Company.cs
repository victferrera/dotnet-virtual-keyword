namespace VirtualKeywordLearning;

public class Company
{
    public virtual void DoWork(string a)
    {
        Console.WriteLine("DoWork from Company {0}", a);
    }

    public void MakeNoise()
    {
        Console.WriteLine("MakeNoise from Company");
    }
}