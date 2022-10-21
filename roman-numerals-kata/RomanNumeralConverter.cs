using static System.Formats.Asn1.AsnWriter;

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
    private string ProcessNumbersOf(int scale)
    {
        var result = string.Empty;
        var numbersToProcess = new int[] { 9, 5, 4 ,1 };
        while (_number >= scale) {
            foreach (var number in numbersToProcess) {
                result += ProcessNumberOnScale(number, scale);
            }
        }
        return result;
    }

    private string ProcessNumberOnScale(int number, int scale)
    {
        var numberToProcess = number * scale;
        if (_number < numberToProcess) return string.Empty;
        _number -= numberToProcess;
        if (numberToProcess.IsMultipleOf(9 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[10 * scale];
        if (numberToProcess.IsMultipleOf(4 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[5 * scale];
        return RomanNumerals[numberToProcess];
    }

}
public static class MultiplesExtension
{
    public static bool IsMultipleOf(this int number, int multiple)
    {
        return number % multiple == 0;
    }
}