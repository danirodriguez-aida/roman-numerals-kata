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
        result += romanNumeralConverter.ProcessNumberLess1000();
        result += romanNumeralConverter.ProcessNumberLess100();
        result += romanNumeralConverter.ProcessNumberLess10();
        return result;
    }

    private string ProcessNumberLess10()
    {
        var result = string.Empty;
        if (_number == 9)
        {
            _number -= 9;
            return RomanNumerals[1] + RomanNumerals[10];
        }
        if (_number >= 5)
        {
            _number -= 5;
            result += RomanNumerals[5];
        }

        if (_number == 4)
        {
            _number -= 4;
            return RomanNumerals[1] + RomanNumerals[5];
        }
        while (_number >= 1)
        {
            _number -= 1;
            result += RomanNumerals[1];
        }
        return result;
    }

    private string ProcessNumberLess100()
    {
        var result = string.Empty;
        if (_number >= 90)
        {
            _number -= 90;
            return RomanNumerals[10] + RomanNumerals[100];
        }
        if (_number >= 50)
        {
            _number -= 50;
            result += RomanNumerals[50];
           
        }
        if (_number >= 40)
        {
            _number -= 40;
            return RomanNumerals[10] + RomanNumerals[50];
        }
        while (_number >= 10)
        {
            _number -= 10;
            result += RomanNumerals[10];
        }
        return result;
    }
    private string ProcessNumberLess1000()
    {
        var result = string.Empty;
        if (_number >= 900)
        {
            _number -= 900;
            return RomanNumerals[100] + RomanNumerals[1000];
        }
        if (_number >= 500)
        {
            _number -= 500;
            result += RomanNumerals[500];
        }
        if (_number >= 400)
        {
            _number -= 40;
            return RomanNumerals[100] + RomanNumerals[500];
        }
        while (_number >= 1000)
        {
            _number -= 100;
            result += RomanNumerals[100];
        }
        return result;
    }
}