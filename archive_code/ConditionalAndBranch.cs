int score = 96;

// conditional operator
string grade = score >= 80 ? "A" : score >= 70 ? "B" : score >= 60 ? "C" : "D";
Console.WriteLine(grade);

Random coin = new();

int flip = coin.Next(0, 2);

Console.WriteLine((flip == 0) ? "heads" : "tails");
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

Console.WriteLine("\n==================================\n");

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{

    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20)
{

    Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// Rigth solution

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}






