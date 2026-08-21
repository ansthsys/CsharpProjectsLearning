/// <summary>
/// Configure Base and Derived Classes
/// <br /><br />
/// Demonstrates single and transitive inheritance, inherited member visibility,
/// abstract, virtual, and sealed members, and implicit inheritance from Object.
/// </summary>

namespace InheritanceConfigureBaseAndDerivedClasses
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk opened.");
        }

        public void HonkHorn()
        {
            Console.WriteLine("Horn honked.");
        }

        public void LockDoors()
        {
            Console.WriteLine("Doors locked.");
        }
    }

    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging.");
        }

        public void DisplayBatteryStatus()
        {
            Console.WriteLine("Battery status displayed.");
        }
    }

    public class CombustionEngineCar : Car
    {
        public int FuelCapacity { get; set; }

        public void Refuel()
        {
            Console.WriteLine("Car refueled.");
        }

        public void CheckOilLevel()
        {
            Console.WriteLine("Oil level checked.");
        }
    }

    public class BaseClass
    {
        public int PublicField;
        protected int ProtectedField;
        internal int InternalField;
        private int PrivateField;

        public void PublicMethod()
        {
        }

        protected void ProtectedMethod()
        {
        }

        internal void InternalMethod()
        {
        }

        private void PrivateMethod()
        {
        }
    }

    public class DerivedClass : BaseClass
    {
        public void AccessPublicMember()
        {
            PublicField = 10;
            PublicMethod();
        }

        public void AccessProtectedMember()
        {
            ProtectedField = 10;
            ProtectedMethod();
        }

        public void AccessInternalMember()
        {
            InternalField = 10;
            InternalMethod();
        }

        public void DemonstratePrivateMemberRule()
        {
            // Private members are not directly accessible in the derived class.
        }
    }

    public abstract class Shape
    {
        public abstract int GetArea();
    }

    public class Square : Shape
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }

        public override int GetArea()
        {
            return _side * _side;
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class SealedBaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method1 in BaseClass");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Method2 in BaseClass");
        }
    }

    public class SealedDerivedClass : SealedBaseClass
    {
        public sealed override void Method1()
        {
            Console.WriteLine("Method1 in DerivedClass");
        }

        public override void Method2()
        {
            Console.WriteLine("Method2 in DerivedClass");
        }
    }

    public class FinalClass : SealedDerivedClass
    {
        public override void Method2()
        {
            Console.WriteLine("Method2 in FinalClass");
        }

        // Method1 cannot be overridden because it is sealed in SealedDerivedClass.
    }

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

    public static class Program
    {
        public static void Main()
        {
            ElectricCar electricCar = new ElectricCar
            {
                Make = "Tesla",
                Model = "Model 3",
                NumberOfDoors = 4,
                BatteryCapacity = 75
            };

            electricCar.StartEngine();
            electricCar.OpenTrunk();
            electricCar.HonkHorn();
            electricCar.LockDoors();
            electricCar.ChargeBattery();
            electricCar.DisplayBatteryStatus();
            electricCar.StopEngine();

            Console.WriteLine();

            Square square = new Square(5);
            Console.WriteLine($"Area of the square = {square.GetArea()}");

            Console.WriteLine();

            Animal animal = new Dog();
            animal.MakeSound();

            Console.WriteLine();

            SealedBaseClass baseObject = new SealedDerivedClass();
            baseObject.Method1();
            baseObject.Method2();

            SealedBaseClass finalObject = new FinalClass();
            finalObject.Method1();
            finalObject.Method2();

            Console.WriteLine();

            Person person1 = new Person
            {
                Name = "Alice",
                Age = 30
            };

            Person person2 = new Person
            {
                Name = "Alice",
                Age = 30
            };

            Person person3 = person1;

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person1.Equals(person3));
        }
    }
}
