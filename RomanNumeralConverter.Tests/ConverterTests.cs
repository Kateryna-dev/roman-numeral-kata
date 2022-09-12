using NUnit.Framework;
using FluentAssertions;

namespace RomanNumeralConverter.Tests
{
    public class ConverterTests
    {

        [Test]
        public void ConvertFromArabic_Shoud_Return_Correct_Numeral_For_Different_Inputs()
        {
            Converter.ConvertFromArabic(1).Should().Be("I");
            Converter.ConvertFromArabic(7).Should().Be("VII");
            Converter.ConvertFromArabic(10).Should().Be("X");
            Converter.ConvertFromArabic(93).Should().Be("XCIII");
            Converter.ConvertFromArabic(71).Should().Be("LXXI");
            Converter.ConvertFromArabic(500).Should().Be("D");
            Converter.ConvertFromArabic(1000).Should().Be("M");
            Converter.ConvertFromArabic(100).Should().Be("C");
        }


        [Test]
        public void ConvertFromRoman_Shoud_Return_Correct_Numeral_For_Different_Inputs()
        {
            Converter.ConvertFromRoman("I").Should().Be(1);
            Converter.ConvertFromRoman("II").Should().Be(2);
            Converter.ConvertFromRoman("X").Should().Be(10);
        }

        [Test]
        public void ConvertFromRoman_Shoud_Return_Zero_For_Invalid_Input()
        {
            Converter.ConvertFromRoman("Hello").Should().Be(0);
        }

        [Test]
        public void RomanNumeralInputIsCorrect_Shoud_Return_True_For_Valid_Input()
        {
            Converter.RomanNumeralInputIsCorrect("XIX").Should().Be(true);
            Converter.RomanNumeralInputIsCorrect("XLI").Should().Be(true);
            Converter.RomanNumeralInputIsCorrect("C").Should().Be(true);
        }

        [Test]
        public void ArabicInputIsCorrect_Shoud_Return_True_For_Valid_Input()
        {
            Converter.ArabicInputIsCorrect(10).Should().Be(true);
            Converter.ArabicInputIsCorrect(555).Should().Be(true);
            Converter.ArabicInputIsCorrect(3999).Should().Be(true);
        }

        [Test]
        public void RomanNumeralInputIsCorrect_Shoud_Return_False_For_Not_Valid_Input()
        {
            Converter.RomanNumeralInputIsCorrect("345").Should().Be(false);
            Converter.RomanNumeralInputIsCorrect("FFF").Should().Be(false);
            Converter.RomanNumeralInputIsCorrect("X0.1").Should().Be(false);
        }

    }
}