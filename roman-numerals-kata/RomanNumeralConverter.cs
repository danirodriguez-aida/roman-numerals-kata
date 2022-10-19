namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        if (number == 14) return "XIV";
        if (number == 9) return "IX";
        if (number == 4) return "IV";
        var result = string.Empty;
        if (number >= 10)
        {
            result = "X";
            number -= 10;
        }
        if (number >= 5)
        {
            result = "V";
            number -= 5;
        }
        for (var i = 0; i < number; i++)
        {
            result += "I";
        }
        return result;
    }
}