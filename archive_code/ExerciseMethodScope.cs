string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

Console.WriteLine();

PrintCircleArea(12);
PrintCircleCircumference(12);
PrintCircleInfo(12);

void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double pi = 3.14159;
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"\nCircle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

