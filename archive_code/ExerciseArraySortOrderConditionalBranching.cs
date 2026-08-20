string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderStreams = orderStream.Split(",");
Array.Sort(orderStreams);

foreach (var item in orderStreams)
{
    if (item.Length != 4)
    {
        Console.WriteLine($"{item}\t- Error");
    }
    else
    {
        Console.WriteLine($"{item}");
    }
}