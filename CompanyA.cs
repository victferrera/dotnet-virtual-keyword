namespace VirtualKeywordLearning;

public class CompanyA : Company
{
    public void DoWork(char a)
    {
        Console.WriteLine("DoWork from CompanyA {0}", a);
    }

    public new void MakeNoise()
    {
        Console.WriteLine("MakeNoise from CompanyA");
    }
}