using System;
using System.Globalization;

decimal userDecimalNumber = 0;
decimal baseNumberSystem = 0;
string result = null;

Console.WriteLine("Enter the number you want to convert");
userDecimalNumber = CheckUserEnter(Console.ReadLine());
Console.WriteLine("Enter the new base number system (from 2 to 20)");
baseNumberSystem = CheckUserEnter(Console.ReadLine());
ConvertToNewNumberSystem(userDecimalNumber, baseNumberSystem);
Console.WriteLine(result);

decimal CheckUserEnter(string? number)
{
    decimal value;
    if (!decimal.TryParse(number, out value))
    {
        Console.WriteLine("Wrong enter");
    }

    return value;
}

void ConvertToNewNumberSystem(decimal userNum, decimal numSys)
{
    var tempResult = (int) userNum;
    while (tempResult > 0)
    {
        result = (tempResult % numSys).ToString(CultureInfo.InvariantCulture) + result;
        tempResult /= (int) numSys;
    }
}