namespace SumSquareDifference
{
    public class Program
    {

         static void Main(string[] args)
        {
            SumSquareDifference(10);
        }

        public static int SumSquareDifference(int number)
        {
            // throw new NotImplementedException();
            var sumOfSquares = 0;
            for (int i = 1; i <= number; i++)
            {
                sumOfSquares += i*i;
            }

            var SquareOfSum = 0;
            for (int i = 1; i <= number; i++)
            {
                SquareOfSum += i;
            }
            SquareOfSum = SquareOfSum* SquareOfSum;

            int result = SquareOfSum - sumOfSquares;
            return result;
        }
    }
}