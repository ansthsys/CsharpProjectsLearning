// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Openg Here!");
Console.WriteLine("Double");
string name = "Openg";
Console.WriteLine(name.Contains("asd"));
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToUpperInvariant());
Console.WriteLine(name.ToLower());
Console.WriteLine(name.ToLowerInvariant());

Console.WriteLine("\n=========================\n");

// The latest version of the .NET Runtime enables you to instantiate an object without having to repeat the type name (target-typed constructor invocation)
// Random dice = new Random(); // also work if just using new() | new() -> DataType varName = new DataType()
Random dice = new();
int roll = dice.Next(1, 10);
int rolla = dice.Next(3);
int rollb = dice.Next();
Console.WriteLine($"dice value: {roll}");
Console.WriteLine($"dice2 value: {rolla}");
Console.WriteLine($"dice3 value: {rollb}");

Console.WriteLine("\n=========================\n");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Console.WriteLine("\n=========================\n");

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


Console.WriteLine("\n=========================\n");

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("dog"))
{
    Console.WriteLine("What does the fox say?");
}