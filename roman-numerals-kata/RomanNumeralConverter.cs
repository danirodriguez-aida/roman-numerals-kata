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

    public RomanNumeralConverter(int number)
    {
        _number = number;
    }
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        var romanNumeralConverter = new RomanNumeralConverter(number);
        result += romanNumeralConverter.ProcessNumberLess(1000);
        result += romanNumeralConverter.ProcessNumberLess(100);
        result += romanNumeralConverter.ProcessNumberLess(10);
        return result;
    }
    private string ProcessNumberLess(int multiplier)
    {
        var result = string.Empty;
        multiplier = (multiplier / 10);
        if (_number >= (9 * multiplier))
        {
            _number -= (9 * multiplier);
            return RomanNumerals[1 * multiplier] + RomanNumerals[10 * multiplier];
        }
        if (_number >= (5* multiplier))
        {
            _number -= (5* multiplier);
            result += RomanNumerals[5* multiplier];
        }

        if (_number >= (4* multiplier))
        {
            _number -= (4* multiplier);
            return RomanNumerals[1* multiplier] + RomanNumerals[5* multiplier];
        }
        while (_number >= (1* multiplier))
        {
            _number -= (1* multiplier);
            result += RomanNumerals[1* multiplier];
        }
        return result;
    }
}