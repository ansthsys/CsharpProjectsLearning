/// <summary>
/// Class Object Initializers and Copy Constructors
/// <br /><br />
/// Demonstrates object initializers, indexer initialization, required and init-only
/// properties, class-typed properties, initialization order, and copy constructors.
/// </summary>

namespace ClassObjectInitializersAndCopyConstructors
{
    public class Cat
    {
        public int Age { get; set; }
        public string? Name { get; set; }

        public Cat()
        {
        }

        public Cat(string name)
        {
            Name = name;
        }
    }

    public class StudentName
    {
        public StudentName()
        {
        }

        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ID { get; set; }

        public override string ToString() => FirstName + "  " + ID;
    }

    public class Matrix
    {
        private double[,] storage = new double[3, 3];

        public double this[int row, int column]
        {
            get { return storage[row, column]; }
            set { storage[row, column] = value; }
        }
    }

    public class BaseballTeam
    {
        private string[] players = new string[9];

        private readonly List<string> positionAbbreviations = new()
        {
            "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
        };

        public string this[int position]
        {
            get { return players[position - 1]; }
            set { players[position - 1] = value; }
        }

        public string this[string position]
        {
            get { return players[positionAbbreviations.IndexOf(position)]; }
            set { players[positionAbbreviations.IndexOf(position)] = value; }
        }
    }

    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public required string LastName { get; set; }
    }

    public class InitPerson
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; init; } = "unknown";
    }

    public class EmbeddedClassTypeA
    {
        public int I { get; set; }
        public bool B { get; set; }
        public string S { get; set; } = string.Empty;
        public EmbeddedClassTypeB ClassB { get; set; }

        public EmbeddedClassTypeA()
        {
            I = 3;
            B = true;
            S = "abc";
            ClassB = new() { BB = true, BI = 43 };
        }

        public override string ToString() => $"{I}|{B}|{S}|||{ClassB}";
    }

    public class EmbeddedClassTypeB
    {
        public int BI { get; set; }
        public bool BB { get; set; }
        public string BS { get; set; } = string.Empty;

        public EmbeddedClassTypeB()
        {
            BI = 23;
            BB = false;
            BS = "BBBabc";
        }

        public override string ToString() => $"{BI}|{BB}|{BS}";
    }

    public class ObjectInitializersExecutionOrder
    {
        public class Dog
        {
            private int age;
            private string name = string.Empty;

            public Dog(int age)
            {
                Console.WriteLine("Hello from Dog's non-parameterless constructor");
                this.age = age;
            }

            public required string Name
            {
                get { return name; }

                set
                {
                    Console.WriteLine(
                        "Hello from setter of Dog's required property 'Name'");
                    name = value;
                }
            }
        }

        public class ExecutionPerson
        {
            private string firstName = string.Empty;
            private string lastName = string.Empty;
            private string city = string.Empty;

            public ExecutionPerson()
            {
                Console.WriteLine(
                    "Hello from Person's parameterless constructor");
            }

            public required string FirstName
            {
                get { return firstName; }

                set
                {
                    Console.WriteLine(
                        "Hello from setter of Person's required property 'FirstName'");
                    firstName = value;
                }
            }

            public string LastName
            {
                get { return lastName; }

                init
                {
                    Console.WriteLine(
                        "Hello from setter of Person's init property 'LastName'");
                    lastName = value;
                }
            }

            public string City
            {
                get { return city; }

                set
                {
                    Console.WriteLine(
                        "Hello from setter of Person's property 'City'");
                    city = value;
                }
            }
        }
    }

    public sealed class CopyPerson
    {
        public CopyPerson(CopyPerson previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }

        public CopyPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public string Details()
        {
            return Name + " is " + Age.ToString();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Cat cat = new Cat
            {
                Age = 10,
                Name = "Fluffy"
            };

            Cat sameCat = new Cat("Fluffy")
            {
                Age = 10
            };

            StudentName student1 = new StudentName("Lisa", "Yeh");

            StudentName student2 = new StudentName
            {
                FirstName = "Sandy",
                LastName = "Zoeng"
            };

            StudentName student3 = new StudentName
            {
                ID = 183
            };

            StudentName student4 = new StudentName
            {
                FirstName = "Thomas",
                LastName = "Margand",
                ID = 116
            };

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student4);

            var identity = new Matrix
            {
                [0, 0] = 1.0,
                [0, 1] = 0.0,
                [0, 2] = 0.0,

                [1, 0] = 0.0,
                [1, 1] = 1.0,
                [1, 2] = 0.0,

                [2, 0] = 0.0,
                [2, 1] = 0.0,
                [2, 2] = 1.0
            };

            var team = new BaseballTeam
            {
                ["RF"] = "Lisa Yeh",
                [4] = "Sandy Zoeng",
                ["CF"] = "Thomas Margand"
            };

            Console.WriteLine(team["2B"]);

            var friend1 = new Person
            {
                FirstName = "Lisa",
                LastName = "Yeh"
            };

            Console.WriteLine($"Hello, {friend1.FirstName} {friend1.LastName}!");

            var friend2 = new Person
            {
                LastName = "Yeh"
            };

            Console.WriteLine($"Hello, {friend2.FirstName} {friend2.LastName}!");

            friend2.FirstName = "Sandy";
            friend2.LastName = "Chen";

            Console.WriteLine($"Hello, {friend2.FirstName} {friend2.LastName}!");

            var friend0 = new InitPerson();
            var friend3 = new InitPerson
            {
                FirstName = "Lisa"
            };

            var friend4 = new InitPerson
            {
                LastName = "Yeh"
            };

            var friend5 = new InitPerson
            {
                FirstName = "Lisa",
                LastName = "Yeh"
            };

            Console.WriteLine($"Hello, {friend0.FirstName} {friend0.LastName}!");
            Console.WriteLine($"Hello, {friend3.FirstName} {friend3.LastName}!");
            Console.WriteLine($"Hello, {friend4.FirstName} {friend4.LastName}!");
            Console.WriteLine($"Hello, {friend5.FirstName} {friend5.LastName}!");

            friend5.FirstName = "Sandy";

            var a = new EmbeddedClassTypeA
            {
                I = 103,
                B = false,
                ClassB = { BI = 100003 }
            };

            Console.WriteLine(
                $"After initializing EmbeddedClassTypeA: {a}");

            var a2 = new EmbeddedClassTypeA
            {
                I = 103,
                B = false,
                ClassB = new() { BI = 100003 }
            };

            Console.WriteLine(
                $"After initializing EmbeddedClassTypeA a2: {a2}");

            new ObjectInitializersExecutionOrder.ExecutionPerson
            {
                FirstName = "Lisa",
                LastName = "Yeh",
                City = "unknown"
            };

            new ObjectInitializersExecutionOrder.Dog(2)
            {
                Name = "Oscar"
            };

            CopyPerson person1 = new CopyPerson("Lisa", 40);
            CopyPerson person2 = new CopyPerson(person1);

            person1.Age = 39;
            person2.Age = 41;
            person2.Name = "Sandy";

            Console.WriteLine(person1.Details());
            Console.WriteLine(person2.Details());
        }
    }
}
