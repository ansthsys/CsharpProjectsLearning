string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;
Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs
Console.WriteLine(objs);
Console.WriteLine(obj);


// ==========


int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs


// ==========


int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs
Console.WriteLine(valueEntered);


// ==========


int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];
values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs


// ==========


object obj1 = "This is a string";
int num = (int)obj1; // InvalidCaseException occurs


// ==========


// NullReferenceException occurs
int[] values = null;
for (int j = 0; j <= 9; j++)
    values[j] = j * 2;

// NullReferenceException occurs
string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());


// ==========


decimal x = 400;
byte i;
i = (byte)x; // OverflowException occurs
Console.WriteLine(i);


// ==========








































