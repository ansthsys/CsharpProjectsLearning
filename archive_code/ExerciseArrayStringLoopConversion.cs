string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;

foreach (var item in values)
{
    if (decimal.TryParse(item, out decimal parsed))
    {
        total += parsed;
    }
    else
    {
        message += item;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");