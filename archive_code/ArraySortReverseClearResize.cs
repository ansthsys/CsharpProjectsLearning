// Array Sort
string[] pallets = ["B14", "A11", "B12", "A13"];


Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Array Reverse Sort
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Array.Clear()
Console.WriteLine("");
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.Write($"After: ");
if (pallets[0] != null)
    Console.WriteLine(pallets[0].ToLower());
Console.WriteLine($"\nClearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Array.Resize() - change array length
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Resizing array for remove item
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

















