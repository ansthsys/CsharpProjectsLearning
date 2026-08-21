/// <summary>
/// Explicit Interface Members
/// <br /><br />
/// Demonstrates how a class can implement multiple interfaces with members
/// that have the same signatures by using explicit interface implementation.
/// The example shows how explicit members are accessed through their
/// corresponding interface instances.
/// </summary>

namespace InterfaceExplicitMembers
{
    public interface IEnglishDimensions
    {
        float Length();
        float Width();
    }

    public interface IMetricDimensions
    {
        float Length();
        float Width();
    }

    public class Box : IEnglishDimensions, IMetricDimensions
    {
        float IEnglishDimensions.Length()
        {
            return 30.0f;
        }

        float IEnglishDimensions.Width()
        {
            return 20.0f;
        }

        float IMetricDimensions.Length()
        {
            return 76.2f;
        }

        float IMetricDimensions.Width()
        {
            return 50.8f;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Box box = new Box();

            IEnglishDimensions eDimensions = box;
            IMetricDimensions mDimensions = box;

            Console.WriteLine($"Length in inches: {eDimensions.Length()}");
            Console.WriteLine($"Width in inches: {eDimensions.Width()}");
            Console.WriteLine($"Length in centimeters: {mDimensions.Length()}");
            Console.WriteLine($"Width in centimeters: {mDimensions.Width()}");
        }
    }
}
