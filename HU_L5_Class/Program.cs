using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_L5_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is "Luhach HaKefel"

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", i * j);
                }
                Console.WriteLine();
            }

            // Practice "while" loop
            // If diffrent then my name, continue to ask for a name

            Console.WriteLine("What is my name?");
            string myName = (Console.ReadLine());
            while (myName != "Lior")
            {
                Console.WriteLine("What is my name?");
                myName = (Console.ReadLine());
            }

            // Get numbers and sum it, stop it when the user enter -1

            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int finalSum = 0;
            while (number != -1)
            {
                finalSum = number + finalSum;
                Console.WriteLine("Please enter a number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The final sum is " + finalSum);

            // 010101

            Console.WriteLine("Please enter a number");
            int newNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < newNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("1 ");
                }
            }

        }
    }
}