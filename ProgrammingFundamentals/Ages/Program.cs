using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ageState = { "baby", "child", "teenager", "adult", "elder" };

            int iAge = 0;

            var age = int.Parse(Console.ReadLine());

            if(age >= 0 && age <= 2)
            {
                iAge = 0;
            }
            else if(age > 2 && age <= 13)
            {
                iAge = 1;
            }
            else if(age > 13 && age <= 19)
            {
                iAge = 2;
            }
            else if(age > 19 && age <= 65)
            {
                iAge = 3;
            }
            else if(age > 65)
            {
                iAge = 4;
            }

            Console.WriteLine(ageState[iAge]);
        }
    }
}
