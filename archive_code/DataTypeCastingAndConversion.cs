// // Will error
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// // Success
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// // Success
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// // Perform Cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// // Narrowing Conversion
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;
// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// // Data Conversion - ToString()
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// // String to Int - Parse()
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// // String to Int - Convert Class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// // Compare Casting and Converting
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);
// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// int value3 = Convert.ToInt32(1.4m); // round down .4
// int value4 = Convert.ToInt32(3.75m);
// Console.WriteLine(value2);
// Console.WriteLine(value3);
// Console.WriteLine(value4);












