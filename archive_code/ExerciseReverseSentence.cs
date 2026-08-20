string pangram = "The quick brown fox jumps over the lazy dog";
string[] arrpangram = pangram.Split(" ");
string[] pangramRes = new string[arrpangram.Length];

for (int i = 0; i < arrpangram.Length; i++)
{

    char[] chars = arrpangram[i].ToCharArray();
    string newWord = string.Join("", chars.Reverse());
    pangramRes[i] = newWord;
}

string pangramresres = string.Join(" ", pangramRes);

Console.WriteLine($"Before:\t{pangram}");
Console.WriteLine($"After:\t{pangramresres}");