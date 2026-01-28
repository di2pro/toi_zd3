using System.Text.RegularExpressions;

var inputBinString = Console.ReadLine();

if (string.IsNullOrEmpty(inputBinString))
{
    return -1;
}

var rule1 = new Regex("\\*1");
var rule2 = new Regex("\\*0");
var rule3 = new Regex("\\*");
var rule4 = new Regex("1");

while (true)
{
    if (inputBinString.Contains("*1"))
    {
        inputBinString = rule1.Replace(inputBinString, "1*", 1);
        continue;
    }

    if (inputBinString.Contains("*0"))
    {
        inputBinString = rule2.Replace(inputBinString, "0*", 1);
        continue;
    }

    if (inputBinString.Contains('*'))
    {
        inputBinString = rule3.Replace(inputBinString, "0", 1);
        break;
    }

    if (inputBinString.Contains('1'))
    {
        inputBinString = rule4.Replace(inputBinString, "*1", 1);
        continue;
    }

    break;
}

Console.WriteLine(inputBinString);

return 0;
