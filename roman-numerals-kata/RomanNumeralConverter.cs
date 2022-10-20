namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        var result = string.Empty;


        // BLOQUE < 100
        if (number >= 90)
        {
            result += "XC";
            number -= 90;
        }
        if (number >= 50)
        {
            result += "L";
            number -= 50;
        }
        if (number >= 40)
        {
            result += "XL";
            number -= 40;
        }
        while (number >= 10)
        {
            result += "X";
            number -= 10;
        }
        // BLOQUE < 10
        if (number == 9)
        {
            return result + "IX";
        }
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