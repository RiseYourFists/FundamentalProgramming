using System;
using System.Linq;
using System.Collections.Generic;
namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var bombNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var bombAndPower = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var bombPos = bombNumbers.IndexOf(bombAndPower[0]);
          
            while(bombPos != -1)
            {
                bombNumbers = BlastRadiusRight(bombNumbers, bombAndPower[1], bombPos);
                bombNumbers = BlastRadiusLeft(bombNumbers, bombAndPower[1], bombPos);
                bombPos = bombNumbers.IndexOf(bombAndPower[0]);
            }

            var result = bombNumbers.Sum();
            Console.WriteLine(result);
        }

        static List<int> BlastRadiusRight(List<int> collection, int blastRadius, int position)
        {
            var result = collection;

            for (int i = 0; i < blastRadius; i++)
            {
                if(position + 1 == result.Count)
                {
                    break;
                }
                result.RemoveAt(position + 1);
            }

            return result;
        }

        static List<int> BlastRadiusLeft(List<int> collection, int blastRadius, int position)
        {
            var result = collection;

            for (int i = 0; i < blastRadius; i++)
            {
                if(position - 1 < 0)
                {
                    break;
                }
                result.RemoveAt(position - 1);
                position--;
            }

            result.RemoveAt(position);

            return result;
        }
    }
}
