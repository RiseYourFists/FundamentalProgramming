using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];

                switch (action)
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        var tempArray = Exchange(initialArray, index);
                        if(tempArray == null)
                        {
                            Console.WriteLine("Invalid index");
                            input = Console.ReadLine();
                            continue;
                        }

                        initialArray = tempArray;
                        break;
                    case "max":
                        string oddOrEven = command[1];
                        Max(initialArray, oddOrEven);
                        break;

                    case "min":
                        oddOrEven = command[1];
                        Min(initialArray, oddOrEven);
                        break;

                    case "first":
                        int count = int.Parse(command[1]);
                        oddOrEven = command[2];
                        First(initialArray, count, oddOrEven);
                        break;

                    case "last":
                        count = int.Parse(command[1]);
                        oddOrEven = command[2];
                        Last(initialArray, count, oddOrEven);
                        break;
                }

                input = Console.ReadLine();
            }

            DisplayCollection(initialArray);
        }

        static int[] Exchange(int[] collection, int index)
        {
            var tempArray = new int[collection.Length];

            if (index < 0 || index > collection.Length - 1)
            {
                return null;
            }

            int counter = 0;
            for (int i = index + 1; i < collection.Length; i++)
            {
                tempArray[counter] = collection[i];
                counter++;
            }

            for (int i = 0; i <= index; i++)
            {
                tempArray[counter] = collection[i];
                counter++;
            }

            return tempArray;
        }

        static void Max( int[] collection, string oddOrEven)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            if(oddOrEven == "odd")
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if(collection[i] % 2 == 0)
                    {
                        continue;
                    }

                    if(collection[i] > max)
                    {
                        max = collection[i];
                        maxIndex = i;
                    }
                    else if(collection[i] == max)
                    {
                        maxIndex = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] % 2 == 1)
                    {
                        continue;
                    }

                    if (collection[i] > max)
                    {
                        max = collection[i];
                        maxIndex = i;
                    }
                    else if (collection[i] == max)
                    {
                        maxIndex = i;
                    }
                }
            }

            if(maxIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine(maxIndex);
        }

        static void Min( int[] collection, string oddOrEven)
        {
            int min = int.MaxValue;
            int minIndex = -1;
            if (oddOrEven == "odd")
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] % 2 == 0)
                    {
                        continue;
                    }

                    if (collection[i] < min)
                    {
                        min = collection[i];
                        minIndex = i;
                    }
                    else if (collection[i] == min)
                    {
                        minIndex = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] % 2 == 1)
                    {
                        continue;
                    }

                    if (collection[i] < min)
                    {
                        min = collection[i];
                        minIndex = i;
                    }
                    else if (collection[i] == min)
                    {
                        minIndex = i;
                    }
                }
            }

            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine(minIndex);
        }

        static void DisplayCollection(int[] array)
        {
            if(array == null)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static void First(int[] collection, int count, string oddOrEven)
        {
            if(count > collection.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int counter = 0;
            int element = 0;
            int[] tempArray = new int[count];
            bool noMatches = true;

            if (oddOrEven == "odd")
            {
                while (counter < count && element < collection.Length)
                {
                    
                    if(collection[element] % 2 == 0)
                    {
                        element++;
                        continue;
                    }

                    tempArray[counter] = collection[element];
                    element++;
                    counter++;
                    noMatches = false;
                }
            }
            else
            {
                while (counter < count && element < collection.Length)
                {
                    if (collection[element] % 2 == 1)
                    {
                        element++;
                        continue;
                    }

                    tempArray[counter] = collection[element];
                    element++;
                    counter++;
                    noMatches = false;
                }
            }

            int[] result = new int[counter];

            if (!noMatches)
            {
                for (int i = 0; i < counter; i++)
                {
                    result[i] = tempArray[i];
                }
                DisplayCollection(result);
                return;
            }

            DisplayCollection(null);
        }

        static void Last(int[] collection, int count, string oddOrEven)
        {
            if (count > collection.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int[] reversedCollection = new int[collection.Length];
            Array.Copy(collection, reversedCollection, collection.Length);
            Array.Reverse(reversedCollection);
            int counter = 0;
            int element = 0;
            int[] tempArray = new int[count];
            bool noMatches = true;

            if (oddOrEven == "odd")
            {
                while (counter < count && element < collection.Length)
                {

                    if (reversedCollection[element] % 2 == 0)
                    {
                        element++;
                        continue;
                    }

                    tempArray[counter] = reversedCollection[element];
                    element++;
                    counter++;
                    noMatches = false;
                }
            }
            else
            {
                while (counter < count && element < collection.Length)
                {
                    if (reversedCollection[element] % 2 == 1)
                    {
                        element++;
                        continue;
                    }

                    tempArray[counter] = reversedCollection[element];
                    element++;
                    counter++;
                    noMatches = false;
                }
            }

            int[] result = new int[counter];

            if(!noMatches)
            {
                for (int i = 0; i < counter; i++)
                {
                    result[i] = tempArray[i];
                }
                Array.Reverse(result);
                DisplayCollection(result);
                return;
            }

            DisplayCollection(null);
        }
    }
}
