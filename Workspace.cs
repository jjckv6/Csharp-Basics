using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpe_basics
{
    class Program
    {
        static void Main(string[] args)
        {
                const byte sample1 = 0x3A;
                byte sample2 = 58;
                int heartRate = 85;
                double deposits = 135002796;
                const float acceleration = 9.800f;
                float mass = 14.6f;
                double distance = 129.763001;
                bool lost = true;
                bool expensive = true;
                const char integral = '\u222B';
                const string greeting = "Hello";
                string name = "Karen";

                if (sample1 == sample2)
                {
                    Console.WriteLine("The Samples are equal.\n");
                }
                else
                {
                    Console.WriteLine("The Samples are not equal.\n");
                }

                if (heartRate >= 40 || heartRate <= 80)
                {
                    Console.WriteLine("Heart rate is normal. \n");
                }
                else
                {
                    Console.WriteLine("Heart Rate is not normal. \n");
                }

                if (deposits >= 100000000)
                {
                    Console.WriteLine("You are exceedingly wealthy. \n");
                }
                else
                {
                    Console.WriteLine("Sorry you are so poor. \n");
                }

                float force = mass * acceleration;
                Console.WriteLine("force = {0} \n", force);

                Console.WriteLine("{0} is the distance \n", distance);

                if (lost == true && expensive == true)
                {
                    Console.WriteLine("I am really sorry! I will get the manager. \n");
                }
                else
                {
                    Console.WriteLine("Here is coupon for 10% off. \n");
                }

                int choice = 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You Chose 1. \n");
                        break;
                    case 2:
                        Console.WriteLine("You Chose 2. \n");
                        break;
                    case 3:
                        Console.WriteLine("You Chose 3. \n");
                        break;
                    default:
                        Console.WriteLine("You made an unknown choice. \n");
                        break;
                }

                Console.WriteLine("{0} is an integral \n", integral);

                for (int i = 5; i <= 10; i++)
                {
                    Console.WriteLine("i = {0} \n", i);
                }

                int age = 0;
                while (age < 6)
                {
                    Console.WriteLine("age = {0} \n", age);
                    age++;
                }

                Console.WriteLine("{0} {1}", greeting, name);
        }
    }
}
