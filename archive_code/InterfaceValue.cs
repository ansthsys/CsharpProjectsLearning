/// <summary>
/// Interface Value
/// <br /><br />
/// Demonstrates the benefits of interfaces, including code reusability,
/// maintainability, error prevention, code quality, and polymorphism.
/// </summary>

namespace InterfaceValue
{
    /// <summary>
    /// Defines a contract for objects that can drive.
    /// </summary>
    public interface IVehicle
    {
        void Drive();
    }

    /// <summary>
    /// Implements the IVehicle interface for a car.
    /// </summary>
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }

    /// <summary>
    /// Implements the IVehicle interface for a bike.
    /// </summary>
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The bike is moving.");
        }
    }

    /// <summary>
    /// Defines a contract for objects that can be drawn.
    /// </summary>
    public interface IDrawable
    {
        void Draw();
    }

    /// <summary>
    /// Implements IDrawable by drawing a circle.
    /// </summary>
    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    /// <summary>
    /// Implements IDrawable by drawing a rectangle.
    /// </summary>
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    public class Program
    {
        private static void DrawShape(IDrawable shape)
        {
            shape.Draw();
        }

        public static void Main()
        {
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.Drive();
            bike.Drive();

            IDrawable circle = new Circle();
            IDrawable rectangle = new Rectangle();

            DrawShape(circle);
            DrawShape(rectangle);
        }
    }
}
