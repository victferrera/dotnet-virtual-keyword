namespace VirtualKeywordLearning;

class Program
{
    static void Main(string[] args)
    {
        // DerivedClass derivedClass = new DerivedClass();
        // derivedClass.Hello("Brian");
        // derivedClass.Number = 0;
        // Console.WriteLine(derivedClass.Number);
        //
        // DerivedClassWithChanges derivedClassWithChanges = new DerivedClassWithChanges();
        // derivedClassWithChanges.Hello("John");

        Shape circle = new Circle(2.5);
        Console.WriteLine("Circle area: {0:F2}", circle.FindArea());

        Shape square = new Square(5);
        Console.WriteLine("Square area: {0:F2}", square.FindArea());

        Shape rectangle = new Rectangle(15, 20);
        Console.WriteLine("Rectangle area: {0:F2}", rectangle.FindArea());
    }
}

class BaseClass
{
    private int _num;
    
    public virtual int Number
    {
        get => _num;
        set => _num = value;
    }
    
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
    // overriding a property only happens if property implements the get and set accessors
    private int _num;
    public override int Number
    {
        get => _num;
        set
        {
            if (value == 0)
                _num = -1;
            else
                _num = value;
        }
    }
    
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