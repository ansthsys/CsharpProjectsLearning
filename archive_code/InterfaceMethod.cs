/// <summary>
/// Interface Method
/// <br /><br />
/// Demonstrates how interfaces define contracts using properties and methods,
/// and how a class provides concrete implementations for all interface members.
/// </summary>

namespace InterfaceMethod
{
    /// <summary>
    /// Defines the contract for a vehicle with speed, color, and driving behavior.
    /// </summary>
    public interface IVehicle
    {
        int Speed { get; set; }
        string Color { get; set; }

        void Drive();
    }

    /// <summary>
    /// Implements the IVehicle interface with concrete properties and a Drive method.
    /// </summary>
    public class Car : IVehicle
    {
        private int _speed;
        private string _color = string.Empty;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car car = new Car
            {
                Speed = 100,
                Color = "Red"
            };

            Console.WriteLine($"Speed: {car.Speed}");
            Console.WriteLine($"Color: {car.Color}");

            car.Drive();
        }
    }
}
