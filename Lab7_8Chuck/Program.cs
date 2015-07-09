using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8Chuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tier = new int[] { 20000, 50000, 75000 };
            //decimal[] rate = new decimal[] { .05m, .1m, .2m, .35m };
            //int[] amount = new int[] { 1000, 4000, 9000 };
            //
            //Console.WriteLine("What is your current income rounded up to the nearest whole dollar?");
            //int income = int.Parse(Console.ReadLine());
            //decimal owed = 0;
            //
            //if (income <= tier[0])
            //    owed = income * rate[0];
            //
            //else if (income <= tier[1] && income > tier[0])
            //    owed = (income - tier[0]) * rate[1] + amount[1];
            //
            //else if (income <= tier[2] && income > tier[1])
            //    owed = (income - tier[1] * rate[2] + amount[1]);
            //else if (income > tier[2])
            //    owed = (income - tier[2] * rate[3] + amount[2]);
            //
            //Console.WriteLine("You owe {0:C} in taxes", owed);

            //OR

            //int income = 0;
            //bool isNum = false;
            //double tax = 0;
            //
            //Console.WriteLine("Welcome to the Tax Calculator!");
            //Console.WriteLine("What is your annual income?");
            //
            //isNum = int.TryParse(Console.ReadLine(), out income);
            //
            //if (isNum)
            //{
            //    if (income < 0)
            //    {
            //        Console.WriteLine("Invalid, try another number.");
            //    }
            //    if (income < 20000)
            //    {
            //        tax += income * .05;
            //    }
            //    else if (income < 50000)
            //    {
            //        double tempIncome = income - 20000;
            //        tax += tempIncome * .1 + 1000;
            //    }
            //    else if (income < 75000)
            //    {
            //        double tempIncome = income - 50000;
            //        tax += tempIncome * .02 + 4000;
            //    }
            //
            //}

            int seconds = DateTime.Now.Second;
            Console.WriteLine(seconds);

            switch (seconds)
            {
                case 0:
                    Console.WriteLine("The hour is just beginning");
                    break;

                case 15:
                    Console.WriteLine("It is 15 minutes past the hour");
                    break;

                case 30:
                    Console.WriteLine("Halfway done!");
                    break;

                case 45:
                    Console.WriteLine("Almost there...");
                    break;

                default:
                    Console.WriteLine("Waiting on it.");
                    break;
            }


            {

            }


            {

            }



        }
    }
}
