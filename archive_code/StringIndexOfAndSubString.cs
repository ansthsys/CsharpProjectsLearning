// String IndexOf, SubString, 

// string message = "Find what is (inside the parentheses)";
// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// openingPosition += 1;
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// // Avoid Hardcoded. not constant so can be replaced
// string message = "What is the value <span>between the tags</span>?";
// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// openingPosition += 6;
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// use constant
string message = "What is the value <span>between the tags</span>?";
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));




