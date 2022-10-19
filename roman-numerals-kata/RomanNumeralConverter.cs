namespace roman_numerals_kata;

public class RomanNumeralConverter
{
    public static string ToRomanNumeral(int number)
    {
        if (number == 2) return "II";
        return "I";
    }
}