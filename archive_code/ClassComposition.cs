public class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructors
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Methods
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("PersonName", 30);
        person.Display();
    }
}