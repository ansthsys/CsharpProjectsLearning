/*
  Do-While with input from user
*/

// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

// =====================

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

// ======================

// parse input number

// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

Console.WriteLine(validNumber);
Console.WriteLine(numericValue);

validNumber = int.TryParse(readResult, out numericValue);

Console.WriteLine(validNumber);
Console.WriteLine(numericValue);

// =======================

// Code project 1 - write code that validates integer input

/*
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/

int outCode1 = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    string? input = Console.ReadLine();
    bool validNum = int.TryParse(input, out outCode1);

    if (validNum)
    {
        if (outCode1 <= 4 || outCode1 >= 11) Console.WriteLine($"You entered {outCode1}. Please enter a number between 5 and 10.");
        else Console.WriteLine($"Your input value ({outCode1}) has been accepted.");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (outCode1 <= 4 || outCode1 >= 11);


// =======================

// Code project 2 - write code that validates string input

/*
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
bool validRole = false;
do
{
    string? input = Console.ReadLine();
    if (
        input != null
        && input.Length > 0
        && (
            input.Trim().ToLower() == "administrator"
            || input.Trim().ToLower() == "manager"
            || input.Trim().ToLower() == "user"
        )
    )
    {
        validRole = true;
        Console.WriteLine($"Your input value ({input}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (!validRole);

// ==============================

// Code project 3 - Write code that processes the contents of a string array
// not valid with challange

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (var item in myStrings)
{
    string[] innerStr = item.Split(".");

    foreach (var innerItem in innerStr)
    {
        Console.WriteLine(innerItem.Trim());
    }
}

// valid with challange
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}


