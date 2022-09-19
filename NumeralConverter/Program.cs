namespace RomanNumeralConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Roman Numeral or Arabic Number to convert");
            string input = Console.ReadLine();
            string message = "Incorrect input";

            if (Int32.TryParse(input, out int number) && Converter.ArabicInputIsCorrect(number))
            {
                string result = Converter.ConvertFromArabic(number);
                message = $"The equivalent Roman Numeral is {result}.";
            }

            else if (Converter.RomanNumeralInputIsCorrect(input))
            {
                int result = Converter.ConvertFromRoman(input);
                message = $"The equivalent Arabic Number is {result}.";
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}