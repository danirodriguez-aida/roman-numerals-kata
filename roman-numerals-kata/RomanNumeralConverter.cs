namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        if (number == 9) return "IX";
        if (number == 10) return "X";
        if (number == 11) return "XI";
        if (number == 4) return "IV";
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