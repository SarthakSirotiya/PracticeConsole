using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //splitting practice
            String newString = "abcdefghijklmnopqrstuvwxyz";
            String[] array = newString.Split('m'); //you can only split at a character
            Console.WriteLine(array[0] + array[1]);
            Console.ReadLine();

            //find fridays in June 2018
            for(int i = 1; i <= DateTime.DaysInMonth(2018,6); i++)
            {
                if (new DateTime(2018, 6, i).DayOfWeek.ToString() == "Friday")
                {
                    Console.WriteLine("June {0}, 2018", i);
                }
            }
            Console.ReadLine();}
    }
}