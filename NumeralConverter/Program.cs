namespace RomanNumeralConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Roman Numeral from I to X");
            int romanNumeral = Converter.ConvertFromRoman(Console.ReadLine());
            string outputString = romanNumeral == 0 ?
                "Incorrect input" : $"The equivalent Arabic Numeral is {romanNumeral}";
            Console.WriteLine(outputString);
            Console.ReadKey();
        }
    }
}