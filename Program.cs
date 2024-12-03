namespace VirtualKeywordLearning;

class Program
{
    static void Main(string[] args)
    {
        DerivedClass derivedClass = new DerivedClass();
        derivedClass.Hello("Brian");

        DerivedClassWithChanges derivedClassWithChanges = new DerivedClassWithChanges();
        derivedClassWithChanges.Hello("John");
    }
}

class BaseClass
{
    public virtual void Hello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    public void NotAVirtualMethod()
    {
        Console.WriteLine("You cant override this method");
    }
}

class DerivedClass : BaseClass
{
    // you cant override this method
    // no suitable method to override error will show
    // public override void NotAVirtualMethod()
    // {
    //     
    // }
}

class DerivedClassWithChanges : BaseClass
{
    public override void Hello(string name)
    {
        Console.WriteLine($"Hello {name}, welcome!");
    }
}