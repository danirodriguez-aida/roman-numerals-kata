namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;

        if (number == 40)  return result + "XL";
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
        while (number >= 1)
        {
            result += "I";
            number -= 1;
        }
        return result;
    }
}