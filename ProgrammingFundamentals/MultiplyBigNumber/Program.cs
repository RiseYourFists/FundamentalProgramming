using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseNumber = Console.ReadLine();
            var multiplier = Console.ReadLine();


            if (multiplier == "0")
            {
                Console.WriteLine(0);
                return;
            }

            var result = MultiplyBigNumber(baseNumber, multiplier);

            Console.WriteLine(result);


        }

        static string MultiplyBigNumber(string baseNumber, string multiplier)
        {
            var modifier = int.Parse(multiplier);
            var result = new StringBuilder();
            var remainder = 0d;

            for (int i = baseNumber.Length - 1; i >= 0; i--)
            {
                var currNum = char.GetNumericValue(baseNumber[i]);

                var multiplication = (currNum * modifier) + remainder;
                var mResult = multiplication.ToString();

                if (mResult.Length > 1)
                {
                    var remainderOfMultiplication = mResult[0];
                    remainder = char.GetNumericValue(remainderOfMultiplication);
                    result.Append(char.GetNumericValue(mResult[1]));

                    if (i == 0)
                    {
                        result.Append(remainder);
                        break;
                    }

                    continue;
                }

                result.Append(mResult);
                remainder = 0;

            }
            var tempstring = result.ToString();
            var finalResult = tempstring.ToCharArray();
            Array.Reverse(finalResult);
            return new string(finalResult);
        }
    }
}
