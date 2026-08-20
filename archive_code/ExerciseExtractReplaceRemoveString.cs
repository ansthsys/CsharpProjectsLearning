/*
    Exercise - Complete a challenge to extract, replace, and remove data from an input string

    Output expected:
    =============================
    Quantity: 5000
    Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string spanOpen = "<span>";
const string spanClose = "</span>";
int spanOpenIdx = input.IndexOf(spanOpen);
int spanOpenIdxLength = spanOpenIdx + spanOpen.Length;
int spanCloseIdx = input.IndexOf(spanClose);
int numLength = spanCloseIdx - spanOpenIdxLength;
string numVal = input.Substring(spanOpenIdxLength, numLength);
quantity = $"Quantity: {numVal}";

const string divOpen = "<div>";
const string divClose = "</div>";
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(divOpen, "").Replace(divClose, "").Replace(tradeSymbol, regSymbol);

Console.WriteLine(quantity);
Console.WriteLine(output);







