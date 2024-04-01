using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test: 
            Console.WriteLine("Choose what do you want to convert");
            Console.WriteLine("Press 1 for seconds to minutes");
            Console.WriteLine("Press 2 for minutes to hours");
            Console.WriteLine("Press 3 for hours to days");
            Console.WriteLine("Press 4 for days to months");
            string mode = (Console.ReadLine());
            int seconds;
            int minutes;
            int hours;
            int days;
            int months;
            int remainder;
              
            if (mode == "1")
            {
                Console.WriteLine("");
                Console.Write("Enter number of second/s: ");
                seconds = Convert.ToInt32(Console.ReadLine());
                if (seconds > 60)
                {
                    minutes = seconds / 60;
                    remainder = seconds % 60;
                    Console.WriteLine(seconds + " second/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + minutes + " minute/s and " + remainder + " second/s");
                    Console.WriteLine("");
                    goto test;
                }
                else
                {
                    Console.WriteLine(seconds + " second/s is ");
                    Console.WriteLine("");
                    Console.WriteLine( "= " + (double)seconds / 60 + " minute/s");
                    Console.WriteLine("");
                    goto test;
                }
            }
            else if (mode == "2")
            {
                Console.WriteLine("");
                Console.Write("Enter number of minute/s: ");
                minutes = Convert.ToInt32(Console.ReadLine());
                if (minutes > 60)
                {
                    hours = minutes / 60;
                    remainder = minutes % 60;
                    Console.WriteLine(minutes + " minutes/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + hours + " hour/s and " + remainder + " minute/s");
                    Console.WriteLine("");
                    goto test;
                }
                else
                {
                    Console.WriteLine(minutes + " minutes/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + (double)minutes / 60 + " hour/s");
                    Console.WriteLine("");
                    goto test;
                }
            }
            else if (mode == "3")
            {
                Console.WriteLine("");
                Console.Write("Enter number of hour/s: ");
                hours = Convert.ToInt32(Console.ReadLine());
                if (hours > 24)
                {
                    days = hours / 24;
                    remainder = hours % 24;
                    Console.WriteLine(hours + " hour/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + days + " day/s and " + remainder + " hour/s");
                    Console.WriteLine("");
                    goto test;
                }
                else
                {
                    Console.WriteLine(hours + " hour/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + (double)hours / 24 + " day/s");
                    Console.WriteLine("");
                    goto test;
                }
            }
            else if (mode == "4")
            {
                Console.WriteLine("");
                Console.Write("Enter number of day/s: ");
                days = Convert.ToInt32(Console.ReadLine());
                if (days > 30)
                {
                    months = days / 30;
                    remainder = days % 30;
                    Console.WriteLine(days + " day/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + months + " month/s and " + remainder + " day/s");
                    Console.WriteLine("");
                    goto test;
                }
                else
                {
                    Console.WriteLine(days + " day/s is ");
                    Console.WriteLine("");
                    Console.WriteLine("= " + (double)days / 30 + " month/s");
                    Console.WriteLine("");
                    goto test;
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid input");
                Console.WriteLine("");
                goto test; 
            }
            Console.ReadKey();
        }
    }
}
