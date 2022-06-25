using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var initialPos = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var result = new int[fieldSize];

            for (int i = 0; i < result.Length; i++)
            {
                if (initialPos.Contains(i))
                {
                    result[i] = 1;
                    continue;
                }

                result[i] = 0;

            }

            var input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command.Length < 3)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var selectedPos = int.Parse(command[0]);
                var direction = command[1];
                var moveToPos = int.Parse(command[2]);

                if (selectedPos >= fieldSize || selectedPos < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if(result[selectedPos] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                result = MoveLadyBug(result, selectedPos, moveToPos, direction);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', result));
        }

        static int[] MoveLadyBug(int[] collection, int iniParams, int moveTo, string direction)
        {
            var result = collection;

            bool isOnEmptySpot = false;
            result[iniParams] = 0;


            while (!isOnEmptySpot)
            {

                if (direction == "left")
                {
                    if (iniParams + 1 - moveTo < 0)
                    {
                        break;
                    }

                    for (int i = iniParams - moveTo; i >= 0; i -= moveTo)
                    {
                        if (result[i] == 0)
                        {
                            result[i] = 1;
                            isOnEmptySpot = true;
                            break;
                        }
                    }
                    if (!isOnEmptySpot)
                    {
                        break;
                    }
                }
                else
                {
                    if (iniParams + 1 + moveTo > result.Length)
                    {
                        break;
                    }

                    for (int i = iniParams + moveTo; i < result.Length; i += moveTo)
                    {
                        if (result[i] == 0)
                        {
                            result[i] = 1;
                            isOnEmptySpot = true;
                            break;
                        }
                    }
                    if (!isOnEmptySpot)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
