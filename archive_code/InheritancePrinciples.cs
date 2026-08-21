/// <summary>
/// Principles of Class Inheritance
/// <br /><br />
/// Demonstrates the principles of class inheritance, including base and
/// derived classes, code reuse, extensibility, encapsulation, consistency,
/// and polymorphism. The examples also compare class inheritance with
/// interface implementation and demonstrate polymorphic behavior through
/// virtual and override members.
/// </summary>

namespace InheritancePrinciples
{
    public class Person
    {
        public string? Name { get; set; }

        public int Age { get; set; }
    }

    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }

        public decimal Salary { get; set; }
    }

    public class HousePet
    {
        public virtual string Speak()
        {
            return "Hello";
        }
    }

    public class Dog : HousePet
    {
        public override string Speak()
        {
            return "Woof";
        }
    }

    public class Cat : HousePet
    {
        public override string Speak()
        {
            return "Meow";
        }
    }

    public interface IDrawable
    {
        void Draw();
    }

    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee
            {
                Name = "John",
                Age = 30,
                EmployeeNumber = 1001,
                Salary = 50000m
            };

            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Employee Number: {employee.EmployeeNumber}");
            Console.WriteLine($"Salary: {employee.Salary}");

            Console.WriteLine();

            HousePet myPet1 = new Dog();
            HousePet myPet2 = new Cat();

            Console.WriteLine(myPet1.Speak());
            Console.WriteLine(myPet2.Speak());

            Console.WriteLine();

            IDrawable circle = new Circle();
            IDrawable rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
        }
    }
}
