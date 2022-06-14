using System;
using System.Numerics;
namespace IntengerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            BigInteger forthNum = BigInteger.Parse(Console.ReadLine());

            BigInteger add = firstNum + secondNum;
            BigInteger divide = add / thirdNum;
            BigInteger multiply = divide * forthNum;


            Console.WriteLine(multiply);
        }
    }
}
