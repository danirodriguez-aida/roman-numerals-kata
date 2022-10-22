namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    private int _number;
    private string _numberInRomanNumeral = string.Empty;
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
        var romanNumeralConverter = new RomanNumeralConverter(number);
        romanNumeralConverter.ProcessNumber();
        return romanNumeralConverter._numberInRomanNumeral;
    }

    private void ProcessNumber()
    {
        while (_number >= 1)
        {          
            _numberInRomanNumeral += ProcessNumberOnScale();
        }
    }

    private string ProcessNumberOnScale()
    {
        var scale = GetScale();
        var scaleSection = GetScaleSection();
        var numberToSubtract = scaleSection * scale;
        _number -= numberToSubtract;
        if (numberToSubtract.Equals(9 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[10 * scale];
        if (numberToSubtract.Equals(4 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[5 * scale];
        return RomanNumerals[numberToSubtract];
    }
    private int GetScaleSection()
    {
        var result = _number / GetScale();
        if (result >= 9) return 9;
        if (result >= 5) return 5;
        if (result >= 4) return 4;
        return 1;
    }

    private int GetScale()
    {
        if (_number >= 1000) return 1000;
        if (_number >= 100) return 100;
        if (_number >= 10) return 10;
        return 1;
    }
}
