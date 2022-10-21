namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    private int _number;
    private static readonly Dictionary<int, string> RomanNumerals = new()
    {
        { 1, "I" },
        { 5, "V" },
        { 10, "X" },
        { 50, "L" },
        { 100, "C" },
        { 500, "D" },
        { 1000, "M" },
    };
   
    private class Multipliers
    {
        public static int Ten => 1;
        public static int OneHundred => 10;
        public static int OneThousand => 100;
        //public static IList<int> GetMultipliers() => new List<int>()
        //{
        //    OneThousand,
        //    OneHundred,
        //    Ten
        //};
    }

    public RomanNumeralConverter(int number)
    {
        _number = number;
    }
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        var romanNumeralConverter = new RomanNumeralConverter(number);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.OneThousand);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.OneHundred);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.Ten);
        return result;
    }
    private string ProcessNumberLess(int multiplier)
    {
        var result = string.Empty;
        var multiplierOf1 = 1 * multiplier;
        var multiplierOf4 = 4 * multiplier;
        var multiplierOf5 = 5 * multiplier;
        var multiplierOf9 = 9 * multiplier;
        var multiplierOf10 = 10 * multiplier;
        if (_number >= multiplierOf9)
        {
            result +=  ConvertToNumeral(9, multiplier);
        }
        if (_number >= multiplierOf5)
        {
            result +=  ConvertToNumeral(5, multiplier);
        }
        if (_number >= multiplierOf4)
        {
            result +=  ConvertToNumeral(4, multiplier);
        }

        while (_number >= multiplierOf1)
        {
            result += ConvertToNumeral(1, multiplier);
        }
        return result;
    }

    private string ConvertToNumeral(int number, int multiplier)
    {
        var numberToProcess = number * multiplier;
        _number -= numberToProcess;
        if (numberToProcess % 9 == 0) return RomanNumerals[1 * multiplier] + RomanNumerals[10 * multiplier];
        if (numberToProcess % 4 == 0) return RomanNumerals[1 * multiplier] + RomanNumerals[5 * multiplier];
        return RomanNumerals[numberToProcess];
    }
}