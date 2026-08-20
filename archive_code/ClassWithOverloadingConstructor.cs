public class Person
{

    public Person()
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine("An instance of the Person class is being instantiated without name or age parameters.");
    }

    public Person(string name)
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine($"An instance of the Person class is being instantiated using a name ({name}) parameter.");
    }

    public Person(string name, int age)
    {
        // Field initialization and constructor logic goes here.

        Console.WriteLine($"An instance of the Person class is being instantiated using name ({name}) and age ({age}) parameters.");
    }
}

static class Program
{
    // the Main method is the entry point of the program.
    static void Main()
    {
        // Person person1 = new Person();
        // Person person2 = new Person("Person Two");
        // Person person3 = new Person("Person Three", 30);
        // Or
        Person person1 = new();
        Person person2 = new("Person Two");
        Person person3 = new("Person Three", 30);
    }
}