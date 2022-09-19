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
            Converter.ConvertFromRoman("XX").Should().Be(20);
            Converter.ConvertFromRoman("I").Should().Be(1);
            Converter.ConvertFromRoman("VII").Should().Be(7);
            Converter.ConvertFromRoman("X").Should().Be(10);
            Converter.ConvertFromRoman("XCIII").Should().Be(93);
            Converter.ConvertFromRoman("LXXI").Should().Be(71);
            Converter.ConvertFromRoman("D").Should().Be(500);
            Converter.ConvertFromRoman("M").Should().Be(1000);
            Converter.ConvertFromRoman("C").Should().Be(100);
            Converter.ConvertFromRoman("LXXI").Should().Be(71);
            Converter.ConvertFromRoman("DXCIX").Should().Be(599);
            Converter.ConvertFromRoman("MMMI").Should().Be(3001);
            Converter.ConvertFromRoman("CCCIII").Should().Be(303);
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


        [Test]
        public void ConvertFromRoman_Shoud_Return_Zero_For_Not_Valid_Input()
        {
            Converter.ConvertFromRoman("Hello").Should().Be(0);
        }


        //[Test]
        //public void ArabicInputIsCorrect_Shoud_Return_False_For_Not_Valid_Input()
        //{
        //    Converter.ArabicInputIsCorrect(10).Should().Be(false);
        //    Converter.ArabicInputIsCorrect(555).Should().Be(false);
        //    Converter.ArabicInputIsCorrect(3999).Should().Be(false);
        //}

    }
}