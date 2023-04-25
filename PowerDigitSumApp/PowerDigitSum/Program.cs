namespace PowerDigitSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            PowerSum(15);
            PowerSum(50);

        }

        public static int PowerSum(int power)
        {
            var sum = 0;
            string numPow = Math.Pow(2, power).ToString();
            char[] numPowArray = numPow.ToCharArray();

            for (int i = 0; i < numPowArray.Length; i++)
            {
                //Console.WriteLine(numPowArray[i]);
                sum += int.Parse(numPowArray[i].ToString());
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}