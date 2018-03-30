using System;

namespace DayofProgammerHackerRankProblem
{
    class Program
    {
        public static void Logic(int yearGiven)

        {

            int leapYear = 244;

            int nonLeapYear = 243;

            int dayOfProgrammer = 256;

            int dayAnswer = 0;

            if (yearGiven <= 1917)

            {
                if (yearGiven % 4 == 0)

                {
                    dayAnswer = dayOfProgrammer - leapYear;

                }
                else

                {
                    dayAnswer = dayOfProgrammer - nonLeapYear;
                }
            }
            else if (yearGiven == 1918)
            {
                nonLeapYear = 230;
                leapYear = 231;
                if (((yearGiven % 4 == 0) && (yearGiven % 100 != 0)) || (yearGiven % 400 == 0))
                {
                    dayAnswer = dayOfProgrammer - leapYear;
                }
                else
                {
                    dayAnswer = dayOfProgrammer - nonLeapYear;
                }
            }
            else if (yearGiven <= 2701)
            {
                if (((yearGiven % 4 == 0) && (yearGiven % 100 != 0)) || (yearGiven % 400 == 0))
                {
                    dayAnswer = dayOfProgrammer - leapYear;
                }
                else
                {
                    dayAnswer = dayOfProgrammer - nonLeapYear;
                }
            }
            Console.WriteLine($"{dayAnswer}.09.{yearGiven}");
        }
        static void Main(string[] args)
        {
            Logic(1917);
        }
    }
}
