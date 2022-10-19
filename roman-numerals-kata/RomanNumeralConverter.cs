namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        if (number == 4) return "IV";
        if (number == 5) return "V";
        var result = string.Empty;
        for (var i = 0; i < number; i++)
        {
            result += "I";
        }
        return result;
    }
}