using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public static class Converter
    {
        private static List<string> romanNumerals = new List<string> () {"0", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"};
        private static List<char> romanSymbols = new List<char>() { 'I', 'V', 'X', 'L', 'C', 'D', 'M'};
        static readonly Dictionary<int, string> numeralsDictionary = new ()
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 6, "VI" },
            { 7, "VII" },
            { 8, "VIII" },
            { 9, "IX" },
            { 10, "X" },
            { 20, "XX" },
            { 30, "XXX" },
            { 40, "XL" },
            { 50, "L" },
            { 60, "LX" },
            { 70, "LXX" },
            { 80, "LXXX" },
            { 90, "XC" },
            { 100, "C" },
            { 200, "CC" },
            { 300, "CCC" },
            { 400, "CD" },
            { 500, "D" },
            { 600, "DC" },
            { 700, "DCC" },
            { 800, "DCCC" },
            { 900, "CM" },
            { 1000, "M" },
            { 2000, "MM" },
            { 3000, "MMM" },
        };

        public static int ConvertFromRoman(string romanNumber) 
        {
            if (!string.IsNullOrWhiteSpace(romanNumber) && romanNumerals.Contains(romanNumber))
            {
                return romanNumerals.IndexOf(romanNumber);
            }
            return 0;
        }

        public static string ConvertFromArabic(int number)
        {
            string result = string.Empty;
            if (!ArabicInputIsCorrect(number)) return result;

            for (int divisor = 1000; divisor >= 1; divisor /= 10)
            {
                var numberPart = number / divisor;
                if (numberPart > 0)
                {
                    result += numeralsDictionary[numberPart * divisor];
                    number -= numberPart * divisor;
                }
            }
            return result;
        }

        public static bool RomanNumeralInputIsCorrect(string inputString) 
        {
            if (string.IsNullOrWhiteSpace(inputString))
            { 
                return false;
            }

            HashSet<char> setOfInputSymbols = new HashSet<char>(inputString.Trim().ToUpper());
            foreach (char symbol in setOfInputSymbols)
            {
                if (!romanSymbols.Contains(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ArabicInputIsCorrect(int number) => number < 4000 && number > 0;
    }
}
