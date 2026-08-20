// Method in C#


// Without parameter
void SayHello()
{
    Console.WriteLine("Hello World");
}

// Method with parameter
static void SayYourName(string yourName)
{
    Console.WriteLine($"Hello {yourName}");
}

// Method with optional parameter, b is optional
// Optional parameter must be placed after all mandatory parameter
int Calculate(int a, int b = 5)
{
    return a * b;
}

SayHello();
SayYourName("Openg");
Console.WriteLine(Calculate(200));
Console.WriteLine(Calculate(200, 50));



// Exercise Method

void DisplayRandomNumbers()
{
    Random random = new();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
}

// // Not valid method return type
// // Use void if method not return anything
// var CheckPrice()
// {
//     Console.WriteLine();
// }

DisplayRandomNumbers();