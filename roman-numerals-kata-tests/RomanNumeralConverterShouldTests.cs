using FluentAssertions;

namespace roman_numerals_kata_tests {
    public class RomanNumeralConverterShouldTests {
        [Test]
        public void return_I_for_1()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(1);
            result.Should().Be("I");
        }
    }

    public class RomanNumeralConverter
    {
        public static string ToRomanNumeral(int number)
        {
            return "I";
        }
    }
}