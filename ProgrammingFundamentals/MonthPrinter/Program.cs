using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = int.Parse(Console.ReadLine());
            string corrMonth = string.Empty;

            switch(month)
            {
                case 1:
                    corrMonth = "January";
                    break;
                case 2:
                    corrMonth = "February";
                    break;
                case 3:
                    corrMonth = "March";
                    break;
                case 4:
                    corrMonth = "April";
                    break;
                case 5:
                    corrMonth = "May";
                    break;
                case 6:
                    corrMonth = "June";
                    break;
                case 7:
                    corrMonth = "July";
                    break;
                case 8:
                    corrMonth = "August";
                    break;
                case 9:
                    corrMonth = "September";
                    break;
                case 10:
                    corrMonth = "October";
                    break;
                case 11:
                    corrMonth = "November";
                    break;
                case 12:
                    corrMonth = "December";
                    break;
                default:
                    corrMonth = "Error!";
                    break;
            }

            Console.WriteLine(corrMonth);
        }
    }
}
