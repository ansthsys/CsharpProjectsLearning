/*
  For the first code sample, the compiler interprets flag as a Boolean variable that could be assigned a value of either true or false. 
  The compiler concludes that if flag is false, value will not be initialized when the second Console.WriteLine() is executed
*/

// // Code sample 1
// // Error
// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// // ========================

// // Code sample 2
// // Not error
// int value;

// if (true)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// // ========================

// // path when flag = true
// int value;
// value = 10;
// Console.WriteLine($"Inside the code block: {value}");
// Console.WriteLine($"Outside the code block: {value}");

// // ========================

// // path when flag = false
// int value;
// Console.WriteLine($"Outside the code block: {value}");
