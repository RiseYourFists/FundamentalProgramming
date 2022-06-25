using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var value1 = int.Parse(Console.ReadLine());
                    var value2 = int.Parse(Console.ReadLine());
                    GetMax(value1, value2);
                    break;
                case "string":
                    var value3 = Console.ReadLine();
                    var value4 = Console.ReadLine();
                    GetMax(value3, value4);
                    break;
                case "char":
                    var value5 = char.Parse(Console.ReadLine());
                    var value6 = char.Parse(Console.ReadLine());
                    GetMax(value5, value6);
                    break;
            }
        }

        static void GetMax(string valueOne, string valueTwo)
        {
            if(valueOne.CompareTo(valueTwo) > 0)
            {
                Console.WriteLine(valueOne);
            }
            else
            {
                Console.WriteLine(valueTwo);
            }
        }
        static void GetMax(int valueOne, int valueTwo)
        {
            if(valueOne > valueTwo)
            {
                Console.WriteLine(valueOne);
            }
            else
            {
                Console.WriteLine(valueTwo);
            }
        }
        static void GetMax(char valueOne, char valueTwo)
        {
            if(valueOne > valueTwo)
            {
                Console.WriteLine(valueOne);
            }
            else
            {
                Console.WriteLine(valueTwo);
            }
        }
    }
}
