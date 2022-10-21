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
        result += romanNumeralConverter.ProcessNumberLess(1000);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.OneThousand);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.OneHundred);
        result += romanNumeralConverter.ProcessNumberLess(Multipliers.Ten);
        return result;
    }
    private string ProcessNumberLess(int multiplier)
    {
        var result = string.Empty;
        var numbersToProcess = new int[] { 9, 5, 4 ,1 };
        while (_number >= multiplier)
        {
            foreach (var number in numbersToProcess) {
                result += ConvertToNumeral(number, multiplier);
            }
        }
        return result;
    }

    private string ConvertToNumeral(int number, int multiplier)
    {
        var numberToProcess = number * multiplier;
        if (_number < numberToProcess) return "";
        _number -= numberToProcess;
        if (numberToProcess % (9 * multiplier) == 0) return RomanNumerals[1 * multiplier] + RomanNumerals[10 * multiplier];
        if (numberToProcess % (4 * multiplier) == 0) return RomanNumerals[1 * multiplier] + RomanNumerals[5 * multiplier];
        return RomanNumerals[numberToProcess];
    }
}