/*

Class Field property Accessor:

- Get accessor
- Set accessor
- Init accessor

*/


using GetAccessor;
using SetAccessor;
using InitAccessor;


namespace GetAccessor
{
    public class Employee
    {
        private string _name = "unknown";  // the name field
        public string Name
        {
            get { return _name; }  // the Name property
        }
    }

    public class Manager
    {
        private string? _name;
        public string Name
        {
            get
            {
                return _name != null ? _name : "NA";
            }
        }
    }
}


namespace SetAccessor
{
    class Student
    {
        private string? _name;  // the name field
        public string Name    // the Name property
        {
            get
            {
                return _name != null ? _name : "NA";
            }
            set
            {
                _name = value;
            }
        }
    }
}


namespace InitAccessor
{
    class Student
    {
        private string? _name;

        public string? Name
        {
            get;
            init;
        }
    }
}


namespace Program
{
    public class Program
    {
        public static void Main()
        {
            // Get Accessor
            GetAccessor.Employee employee = new GetAccessor.Employee();  // create an instance of the Employee class
            Console.WriteLine(employee.Name);  // use the get accessor to read the value of the Name property


            // Set Accessor
            var student = new SetAccessor.Student() { Name = "Udin" };
            Console.WriteLine($"studen Name (Set Accessor): {student.Name}");  // the get accessor is invoked here
            student.Name = "StudentName";  // the set accessor is invoked here
            Console.WriteLine($"studen Name (Set Accessor): {student.Name}");  // the get accessor is invoked here


            // Init Accessor
            InitAccessor.Student student1 = new InitAccessor.Student() { Name = "asd" }; // private field with init-accessor can only filled when object initialized
            // student1.Name = "Asdf"; // Will error "Init-only property or indexer 'Student.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.CS8852"
            Console.WriteLine($"student1 Name (Init Accessor): {student1.Name}");
        }
    }
}






