string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void PrintEmail(string[,] names, string domain = "contoso.com")
{

    for (int i = 0; i < names.GetLength(0); i++)
    {
        string firstName = names[i, 0].ToLower();
        string lastName = names[i, 1].ToLower();
        string firstName2Char = firstName.Substring(0, 2);
        string email = $"{firstName2Char}{lastName}@{domain}";
        Console.WriteLine(email);
    }
}

PrintEmail(corporate);
Console.WriteLine();
PrintEmail(external, domain: externalDomain);
