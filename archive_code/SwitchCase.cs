int employeeLevel = 201;
string employeeName = "John Smith";

string title;

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        Console.WriteLine(title);
        break;
    case 200:
        title = "Senior Associate";
        Console.WriteLine(title);
        break;
    case 300:
        title = "Manager";
        Console.WriteLine(title);
        break;
    case 400:
        title = "Senior Manager";
        Console.WriteLine(title);
        break;
    default:
        title = "Associate";
        Console.WriteLine(title);
        break;
}

Console.WriteLine($"{employeeName}, {title}");