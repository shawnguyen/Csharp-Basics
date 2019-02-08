using System;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            char integral = '\u222B';
            String name = "Karen";
            String greeting = $"Hello {name}";

            //Sample Comparasion
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            //Heart Rate
            if (heartRate >= 40 & heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            //Deposits
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            //Force
            float force = mass * acceleration;
            string result = "Force = ";
            Console.WriteLine("{0}{1}", result, force);

            //Distance
            Console.WriteLine("{0} is the distance.", distance);

            //Lost & Expensive
            if (lost & expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }

            //Choice
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice");
                    break;
            }

            //Integral
            string isAN = " is an integral.";
            Console.WriteLine("{0}{1}", integral, isAN);

            //For Loop
            for (int i = 5; i < 11; i = i + 1)
            {
                Console.WriteLine("i = {0}", i);
            }

            //Age
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("Age = {0}", age);
                age++;
            }

            //Name String
            Console.WriteLine("{0}", greeting);
        }
    }
}
