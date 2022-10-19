namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        if (number == 9) return "IX";
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
        if (number % 10 == 4)
        {
            result += "IV";
            number -= 4;
        }
        for (var i = 0; i < number; i++)
        {
            result += "I";
        }
        return result;
    }
}