using FluentAssertions;
using roman_numerals_kata;

namespace roman_numerals_kata_tests {
    public class RomanNumeralConverterShouldTests {


        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(9,"IX")]
        [TestCase(10,"X")]
        public void return_roman_numeral_for(int number, string expected)
        {
            var result = RomanNumeralConverter.ToRomanNumeral(number);
            result.Should().Be(expected);
        }
    }
}