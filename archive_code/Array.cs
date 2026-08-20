// First way initialize array, define length then assign the value
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine(fraudulentOrderIDs);
Console.WriteLine(fraudulentOrderIDs.Length);

// Error, length already fixed to 3 item from index 0-2
// fraudulentOrderIDs[3] = "A04";
// fraudulentOrderIDs[10] = "A04";
// Console.WriteLine(fraudulentOrderIDs);
// Console.WriteLine(fraudulentOrderIDs.Length);


Console.WriteLine($"First: \t\t\t{fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: \t\t{fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: \t\t\t{fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: \t{fraudulentOrderIDs[0]}");


Console.WriteLine("\n=====================================\n");

// Simple create array
// Both syntaxes are valid.
// New way in C# 12 and .NET10
string[] fraudulentOrderIDs2 = ["A123", "B456", "C789"];
// Old way
string[] fraudulentOrderIDs3 = { "A123", "B456", "C789" };

Console.WriteLine(fraudulentOrderIDs2);
Console.WriteLine(fraudulentOrderIDs3);
Console.WriteLine(fraudulentOrderIDs2.Length);
Console.WriteLine(fraudulentOrderIDs3.Length);

Console.WriteLine("\n=====================================\n");

// Looping

// Loop name

string[] names = ["abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
foreach (var item in names)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=====================================\n");

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

Console.WriteLine($"Before: {sum}");

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = item ({item}), total ({sum})");
}

Console.WriteLine($"After Sum: {sum}");

Console.WriteLine("\n=====================================\n");


string[] codes = ["B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"];

foreach (var item in codes)
{
    if (item.Contains("B"))
    {
        Console.WriteLine(item);
    }
}




