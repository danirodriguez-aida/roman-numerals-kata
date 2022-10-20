namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    private int _number;

    public RomanNumeralConverter(int number)
    {
        _number = number;
    }
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        var romanNumeralConverter = new RomanNumeralConverter(number);
        result += romanNumeralConverter.ProcessNumberLess100();
        result += romanNumeralConverter.ProcessNumberLess10();
        return result;
    }

    private string ProcessNumberLess10()
    {
        var result = string.Empty;
        if (_number == 9)
        {
            return result + "IX";
        }
        if (_number >= 5)
        {
            result += "V";
            _number -= 5;
        }
        if (_number == 4)  return result + "IV";
        while (_number >= 1)
        {
            result += "I";
            _number -= 1;
        }
        return result;
    }
    private string ProcessNumberLess100()
    {
        var result = string.Empty;
        if (_number >= 90)
        {
            result += "XC";
            _number -= 90;
        }
        if (_number >= 50)
        {
            result += "L";
            _number -= 50;
        }
        if (_number >= 40)
        {
            result += "XL";
            _number -= 40;
        }
        while (_number >= 10)
        {
            result += "X";
            _number -= 10;
        }
        return result;
    }
}