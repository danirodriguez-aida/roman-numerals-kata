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

    private static readonly Dictionary<int, Func<int, string>> RomanNumeralCalc = new()
    {
       { 1, (scale) => RomanNumerals[1 * scale]},
       { 4, (scale) => RomanNumerals[1 * scale] + RomanNumerals[5 * scale]},
       { 5, (scale) => RomanNumerals[5 * scale]},
       { 9, (scale) => RomanNumerals[1 * scale] + RomanNumerals[10 * scale]},
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
        return RomanNumeralCalc[scaleSection](scale);
    }


    private int GetScaleSection()
    {
        var scaleSection = _number / GetScale();
        if (scaleSection >= 9) return 9;
        if (scaleSection >= 5) return 5;
        if (scaleSection >= 4) return 4;
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
