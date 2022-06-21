using System;

namespace MaxOccuranceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var maxElements = 0;
            var biggest = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                var currElement = text[i];
                var elements = 0;

                if(currElement == text[i + 1])
                {
                    var testValue = new string[text.Length - i];
                    Array.Copy(text, i + 1, testValue, 0, text.Length - (i + 1));
                    elements = NumberOfElements(currElement, testValue);
                }

                if(elements > maxElements)
                {
                    maxElements = elements;
                    var textToDisplay = new string[1 + elements];
                    Array.Copy(text, i, textToDisplay, 0, 1 + elements);
                    biggest = string.Join(' ', textToDisplay);
                }

            }

            Console.WriteLine(biggest);

            static int NumberOfElements(string element, string[] elements)
            {
                var result = 0;

                for (int i = 0; i < elements.Length; i++)
                {
                    if(element == elements[i])
                    {
                        result++;
                        continue;
                    }

                    break;
                }

                return result;
            }
        }
    }
}
