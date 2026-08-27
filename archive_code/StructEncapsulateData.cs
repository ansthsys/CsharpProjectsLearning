using System;

/// <summary>
/// Structs: Encapsulate Data
/// <br /><br />
/// Demonstrates how structs work as value types, how to define and encapsulate
/// data, how to create readonly structs for immutability, how to use object
/// initializers, and how structs can represent lightweight data with behavior.
/// </summary>
namespace StructEncapsulateData
{
  /// <summary>
  /// Represents a point using public fields and a constructor.
  /// </summary>
  public struct Point
  {
    public int X;
    public int Y;

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }
  }

  /// <summary>
  /// Represents a rectangle with encapsulated fields and a computed property.
  /// </summary>
  public struct Rectangle
  {
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
      this.width = width;
      this.height = height;
    }

    public int Area => width * height;
  }

  /// <summary>
  /// Represents an immutable point using a readonly struct.
  /// </summary>
  public readonly struct ImmutablePoint
  {
    public int X { get; init; }
    public int Y { get; init; }

    public ImmutablePoint(int x, int y)
    {
      X = x;
      Y = y;
    }
  }

  /// <summary>
  /// Represents a point whose properties can be initialized
  /// using an object initializer.
  /// </summary>
  public struct InitializablePoint
  {
    public int X { get; set; }
    public int Y { get; set; }
  }

  /// <summary>
  /// Represents a point in two-dimensional space and provides
  /// a method for calculating the distance to another point.
  /// </summary>
  public struct DistancePoint
  {
    public int X { get; }
    public int Y { get; }

    public DistancePoint(int x, int y)
    {
      X = x;
      Y = y;
    }

    public double DistanceTo(DistancePoint other)
    {
      int dx = X - other.X;
      int dy = Y - other.Y;

      return Math.Sqrt(dx * dx + dy * dy);
    }
  }

  public class Program
  {
    public static void Main()
    {
      var point = new Point(10, 20);

      Console.WriteLine($"Point: ({point.X}, {point.Y})");

      var rectangle = new Rectangle(10, 5);

      Console.WriteLine($"Rectangle area: {rectangle.Area}");

      var immutablePoint = new ImmutablePoint(3, 4);

      Console.WriteLine(
          $"Immutable point: ({immutablePoint.X}, {immutablePoint.Y})"
      );

      var initializedPoint = new InitializablePoint
      {
        X = 10,
        Y = 20
      };

      Console.WriteLine(
          $"Initialized point: ({initializedPoint.X}, {initializedPoint.Y})"
      );

      var point1 = new DistancePoint(3, 4);
      var point2 = new DistancePoint(7, 1);

      Console.WriteLine(
          $"Distance between points: {point1.DistanceTo(point2)}"
      );
    }
  }
}

