using System;

var userSymbols = Console.ReadLine();
var uniqueChars = 0;

foreach (var ySymbol in userSymbols)
{
    var tempUniqueChars = 0;
    foreach (var ySymbol2 in userSymbols)
    {
        if (ySymbol == ySymbol2) tempUniqueChars += 1;

    }

    if (tempUniqueChars == 1) uniqueChars += 1;
}
Console.WriteLine(uniqueChars);
