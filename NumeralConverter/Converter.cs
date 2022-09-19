namespace RomanNumeralConverter
{
    public static class Converter
    {
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

        public static int ConvertFromRoman(string romanNumber)
        {
            int result = 0;
            if (!RomanNumeralInputIsCorrect(romanNumber)) return result;

            //Creating reversed dictionary where roman numeral is a key and equivalent arabic number is value
            Dictionary<string, int> reversedDictionary = numeralsDictionary.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
            romanNumber = romanNumber.Trim().ToUpper();
            string substring = romanNumber;
            string notFounded = string.Empty;

            while (substring.Length > 0)
            {
                if (reversedDictionary.ContainsKey(substring))
                {
                    result += reversedDictionary[substring];
                    substring = notFounded;
                    notFounded = string.Empty;
                }
                else 
                {
                    notFounded += substring[0];
                    //equivalent of substring.Substring(1)
                    substring = substring[1..];
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
            string romanSymbols = "IVXLCDM";
            inputString = inputString.Trim().ToUpper();
            foreach (char symbol in inputString)
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
