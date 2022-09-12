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
        private static char[] romanSymbols = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M'};

        public static int ConvertFromRoman(string romanNumber) 
        {
            if (!string.IsNullOrWhiteSpace(romanNumber) && romanNumerals.Contains(romanNumber))
            {
                return romanNumerals.IndexOf(romanNumber);
            }
            return 0;
        }


        public static string ConvertFromArabic(int arabicNumeral)
        {
            if (arabicNumeral < 11)
            {
                return romanNumerals[arabicNumeral];
            }
            return "Not implemented yet"; ;
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

    }
}
