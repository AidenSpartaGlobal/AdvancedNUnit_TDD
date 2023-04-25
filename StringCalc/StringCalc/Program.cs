using System.Text.RegularExpressions;
using System.Xml;


namespace StringCalc
{
    public class StringCalcProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("12 *% 3 || 1"));

        }
        public static string Add(string input)
        {
            if (input == "") return "0";
            
            var number = Regex.Matches(input, @"[0-9]+");
            var number2 = Regex.Matches(input, "^-\\d+$");
            string negNumbers = "";
            List<int> intArrayNeg = new List<int>();
            foreach (Match num in number2)
            {
                intArrayNeg.Add(Int32.Parse(num.Value));
                negNumbers += "" + num.Value;
            }

            if (intArrayNeg.Count > 0)
            {
                throw new ArgumentException($"The following: {negNumbers} \n  Reason: Negatives not allowed");
            }

            List<int> intArray = new List<int>();
            foreach (Match numbers in number)
            {
                if (Int32.Parse(numbers.Value) >=1000 )
                {
                    continue;
                }
                intArray.Add(Int32.Parse(numbers.Value));
            }
            return intArray.Sum().ToString();

        }
    }
}