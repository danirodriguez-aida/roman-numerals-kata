namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;
        while (number >= 10)
        {
            result += "X";
            number -= 10;
        }
        if (number == 9) return result + "IX";
        if (number >= 5)
        {
            result += "V";
            number -= 5;
        }
        if (number == 4)  return result + "IV";
        for (var i = 0; i < number; i++)
        {
            result += "I";
        }
        return result;
    }
}