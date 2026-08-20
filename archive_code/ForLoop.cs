for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("// ============================");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("// ============================");

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine("// ============================");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

Console.WriteLine("// ============================");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("// ============================");

// // Will error
// string[] names2 = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names2)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// posible if using for loop
string[] names2 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names2.Length; i++)
{
    if (names2[i] == "David")
    {
        names2[i] = "Sammy";
    }
}

foreach (var name in names2)
{
    Console.WriteLine(name);
}

