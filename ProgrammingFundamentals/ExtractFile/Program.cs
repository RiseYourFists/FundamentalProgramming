using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var extensionIndex = input.LastIndexOf('.');
            var fileNameIndex = input.LastIndexOf('\\');
            var extension = input.Substring(extensionIndex + 1);
            var len = (input.Length - (fileNameIndex + 1)) - (extension.Length + 1);
            var fileName = input.Substring(fileNameIndex + 1, len);
            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }
    }
}
