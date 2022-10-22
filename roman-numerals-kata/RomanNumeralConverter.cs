namespace roman_numerals_kata;

public class RomanNumeralConverter {
    private int _number;
    private string _numberInRomanNumeral = string.Empty;
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

    public RomanNumeralConverter(int number) {
        _number = number;
    }

    public static string ToRomanNumeral(int number) {
        var romanNumeralConverter = new RomanNumeralConverter(number);
        romanNumeralConverter.ProcessNumber();
        return romanNumeralConverter._numberInRomanNumeral;
    }

    private void ProcessNumber() {
        var numbersToProcess = new int[] { 9, 5, 4, 1 };
        while (_number >= 1) {
            var scale = GetScale();
            foreach (var number in numbersToProcess) {
                _numberInRomanNumeral += ProcessNumberOnScale(number, scale);
            }
        }
    }

    private string ProcessNumberOnScale(int number, int scale) {
        var numberToProcess = number * scale;
        if (_number < numberToProcess) return string.Empty;
        _number -= numberToProcess;
        if (numberToProcess.Equals(9 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[10 * scale];
        if (numberToProcess.Equals(4 * scale)) return RomanNumerals[1 * scale] + RomanNumerals[5 * scale];
        return RomanNumerals[numberToProcess];
    }

    private int GetScale()
    {
        if (_number >= 1000) return 1000;
        if (_number >= 100) return 100;
        if (_number >= 10) return 10;
        return 1;
    }
}
