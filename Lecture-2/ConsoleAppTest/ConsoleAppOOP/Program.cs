// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//class configure

//Person person1= new Person();
//person1.PrintSomething();

//class Person
//{
//    //fields
//    public int name;
//    public int age;
//    //property
//    //method
//    public void PrintSomething()
//    {
//        Console.WriteLine("OOP");
//    }
//}

//Person person1 = new Person();
//Console.WriteLine(person1.Name);

//Person person2 = new Person(2, "xyz");
//Console.WriteLine(person2.Name);

////Constructor
//class Person
//{
//    public string Name;
//    public int Age;
//    //default constructor
//    public Person()
//    {
//        Name = "";
//    }

//    //parameterized constructor
//    public Person(int age, string name)
//    {
//        Age = age;
//        Name = name;
//    }

//}

//Access Modifier
//public, private, protected
//Person person1 = new Person();

//Console.WriteLine(person1.Name);
//public class Person
//{
//    public string Name = "shdgc";
//    private int Age = 2;
//    protected int my = 2;
//    protected void Method()
//    {

//    }

//}
//public class A : Person
//{
//    public int RetValue()
//    {
//        return my;
//    }

//}

//static keyword
//Person personSt = new Person();
//Console.WriteLine(personSt.IncrementStatic());

//Person personSt2 = new Person();
//Console.WriteLine(personSt2.IncrementStatic());

//Person personNonSt = new Person();
//Console.WriteLine(personNonSt.IncrementNonStatic());

//Person personNonSt2 = new Person();
//Console.WriteLine(personNonSt2.IncrementNonStatic());

//public class Person
//{
//    static public int StCounter = 0;

//    public int NonStCounter = 0;

//    public int IncrementNonStatic()
//    {
//        return ++NonStCounter;
//    }
//    public int IncrementStatic()
//    {
//        return ++StCounter;
//    }

//}


//polymorphism
//method overloading
//Summation sum = new Summation();
//sum.Sum(1, 2);
//sum.Sum(1.2D, 2.1D);
//class Summation
//{
//    public void Sum(int a, int b)
//    {
//        Console.WriteLine("Int");
//    }
//    public void Sum(double a, double b)
//    {
//        Console.WriteLine("Double");
//    }
//}

//overriding

//Child ch = new Child();
//ch.DoSomething();
//class Person
//{
//    virtual public void DoSomething()
//    {
//        Console.WriteLine("default method");
//    }
//}
//class Child : Person
//{
//    override public void DoSomething()
//    {
//        Console.WriteLine("over ride method");
//    }
//}

//abstraction

//Person2 p = new Person2();
//p.DoSomething2();
//abstract class Person
//{
//    public void DoSomething()
//    {
//        Console.WriteLine(" I am from abstract class");
//    }
//    abstract public void DoSomething2();
//}
//class Person2 : Person
//{
//    public override void DoSomething2()
//    {
//        Console.WriteLine("THis is in a different implementation class");
//    }
//}

//interface IPerson
//{
//    public void DoSomething()
//    {
//        Console.WriteLine("Interface");
//    }

//    public void DoSomething2();
//}

//class P : IPerson
//{
//    public void DoSomething2()
//    {
//        throw new NotImplementedException();
//    }
//}

//class A
//{

//}
//class B
//{

//}

//interface IA
//{

//}
//interface IB
//{

//}

//class X: IA, IB
//{

//}


Person person100 = new Person();
Console.WriteLine(person100.Pwd);
person100.Pwd = 5;
Console.WriteLine(person100.Pwd);
class Person
{
    private int pwd = 123;
    public int Pwd { get { return pwd; } set { pwd = value; } }
}
