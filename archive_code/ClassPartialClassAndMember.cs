using System;

namespace ClassPartialClassAndMember
{
    /// <summary>
    /// ClassPartialClassAndMember
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// A partial class allows the definition of a class to be split across
    /// multiple source files. All parts are combined by the compiler into
    /// a single type.
    /// </para>
    ///
    /// <br><br>
    ///
    /// <para>
    /// Partial classes are useful when multiple developers work on the same class,
    /// when part of the source code is automatically generated, or when a large
    /// class needs to be divided into multiple files for easier maintenance.
    /// </para>

    public partial class Employee
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
            Console.WriteLine("Employee is at lunch.");
        }
    }


    /// <summary>
    /// Nested Partial Classes
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// A nested class can also be declared as partial. The containing class
    /// does not need to be partial.
    /// </para>

    class Container
    {
        partial class Nested
        {
            void Test() { }
        }

        partial class Nested
        {
            void Test2() { }
        }
    }


    /// <summary>
    /// Members Shared Across Partial Definitions
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// Members declared in one part of a partial class are available to all
    /// other parts because all parts represent the same type.
    /// </para>

    public partial class Coords
    {
        private int x;
        private int y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", x, y);
        }
    }


    /// <summary>
    /// Combining Attributes in Partial Classes
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// Attributes from all partial type definitions are combined into the
    /// final type during compilation.
    /// </para>

    [Serializable]
    [Obsolete]
    partial class Moon
    {
    }


    /// <summary>
    /// Combining Interfaces in Partial Classes
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// Different parts of a partial class can specify different interfaces.
    /// The final type implements all interfaces specified across its partial
    /// definitions.
    /// </para>

    public class Planet
    {
    }

    public interface IRotate
    {
    }

    public interface IRevolve
    {
    }

    partial class Earth : Planet, IRotate
    {
    }

    partial class Earth : IRevolve
    {
    }


    /// <summary>
    /// Partial Methods
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// A partial class can contain a partial method. One part of the class
    /// declares the method while another part provides its implementation.
    /// </para>

    partial class Person
    {
        partial void OnNameChanged();
    }

    partial class Person
    {
        partial void OnNameChanged()
        {
            Console.WriteLine("Name changed.");
        }

        public void ChangeName()
        {
            OnNameChanged();
        }
    }


    /// <summary>
    /// Main Program
    /// </summary>
    ///
    /// <br><br>
    ///
    /// <para>
    /// The partial Employee and Coords classes can be used normally because
    /// their separate definitions are combined into a single type.
    /// </para>

    public class Program
    {
        public static void Main()
        {
            Employee emp = new Employee();

            emp.DoWork();
            emp.GoToLunch();

            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();

            Person person = new Person();
            person.ChangeName();
        }
    }
}
