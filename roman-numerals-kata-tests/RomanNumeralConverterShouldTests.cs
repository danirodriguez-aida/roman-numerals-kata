using FluentAssertions;
using roman_numerals_kata;

namespace roman_numerals_kata_tests {
    public class RomanNumeralConverterShouldTests {
        [Test]
        public void return_I_for_1()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(1);
            result.Should().Be("I");
        }

        [Test]
        public void return_II_for_2()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(2);
            result.Should().Be("II");
        }

        [Test]
        public void return_III_for_3()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(3);
            result.Should().Be("III");
        }

        [Test]
        public void return_IV_for_4()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(4);
            result.Should().Be("IV");
        }

        [Test]
        public void return_IV_for_5()
        {
            var result = RomanNumeralConverter.ToRomanNumeral(5);
            result.Should().Be("V");
        }
    }
}