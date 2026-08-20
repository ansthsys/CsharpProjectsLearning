
// Reversing String 
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);


// using construct String
string result0 = new string(valueArray);

// using .Join()
string result1 = String.Join(",", valueArray);
string result2 = String.Join("", valueArray);


Console.WriteLine(result0);
Console.WriteLine(result1);
Console.WriteLine(result2);


// string to array using .Split()
string[] items = result1.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
































