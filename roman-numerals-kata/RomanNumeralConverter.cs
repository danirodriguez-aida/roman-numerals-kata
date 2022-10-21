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
   
    private class NumericalScale
    {
        public static int Units => 1;
        public static int Tens => 10;
        public static int Hundreds => 100;
        public static int Thousands => 1000;
        public static IList<int> GetScales() => new List<int>()
        {
            Thousands,
            Hundreds,
            Tens,
            Units
        };
    }

    public RomanNumeralConverter(int number)
    {
        _number = number;
    }
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        var romanNumeralConverter = new RomanNumeralConverter(number);
        foreach (var scale in NumericalScale.GetScales())
        {
            result += romanNumeralConverter.ProcessNumbersOf(scale);
        }
        return result;
    }
    private string ProcessNumbersOf(int multiplier)
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