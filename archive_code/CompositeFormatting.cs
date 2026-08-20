using System.Globalization;

// Set localization to en-US
// Will affect currency
CultureInfo.CurrentCulture = new CultureInfo("id-ID");

// Composite Formatting
string first = "Hello";
string second = "World";

// Old Way
Console.WriteLine("{0} {1}", first, second);
Console.WriteLine("{1} {0}", first, second);
Console.WriteLine("{0} {0}", first);


// New Way
Console.WriteLine($"{first} {second}");


// Composite Formatting Number

// Specifier	Nama	                            Contoh (1234.567)
// C	        Currency	                        $1,234.57
// N	        Number	                            1,234.57
// P	        Percent	                            123,456.70%
// F	        Fixed-point                         1234.57
// G	        General	                            1234.567
// E	        Exponential (Scientific)            1.234567E+003
// X	        Hexadecimal (integer saja)	        FF
// D	        Decimal (integer, bisa padding)	    00042
// B	        Binary (C#/.NET versi baru)	        101010
// R	        Round-trip (float/double)	        Menjaga nilai tetap akurat saat dikonversi ke string dan kembali lagi.

decimal number = 1234.5678m;
decimal percent = 0.36785m;
int integer = 255;
int value = 42;
int binary = 10;

Console.WriteLine($"\nCurrency info: {System.Globalization.CultureInfo.CurrentCulture}");

Console.WriteLine("\n=== C - Currency ===");
Console.WriteLine("{0:C}", number);
Console.WriteLine($"{number:C}");

Console.WriteLine("\n=== N - Number ===");
Console.WriteLine("{0:N}", number);
Console.WriteLine("{0:N4}", number);

Console.WriteLine("\n=== P - Percent ===");
Console.WriteLine("{0:P}", percent);
Console.WriteLine("{0:P1}", percent);
Console.WriteLine($"{33:P1}");
Console.WriteLine($"{33.234:P1}");

Console.WriteLine("\n=== F - Fixed-point ===");
Console.WriteLine("{0:F}", number);
Console.WriteLine("{0:F3}", number);

Console.WriteLine("\n=== G - General ===");
Console.WriteLine("{0:G}", number);

Console.WriteLine("\n=== E - Exponential ===");
Console.WriteLine("{0:E}", number);
Console.WriteLine("{0:E2}", number);

Console.WriteLine("\n=== D - Decimal (Integer) ===");
Console.WriteLine("{0:D}", value);
Console.WriteLine("{0:D5}", value);

Console.WriteLine("\n=== X - Hexadecimal ===");
Console.WriteLine("{0:X}", integer);
Console.WriteLine("{0:X4}", integer);
Console.WriteLine("{0:x}", integer);

// Hanya tersedia di .NET 8 / C# versi terbaru
Console.WriteLine("\n=== B - Binary ===");
Console.WriteLine("{0:B}", binary);
Console.WriteLine("{0:B8}", binary);





