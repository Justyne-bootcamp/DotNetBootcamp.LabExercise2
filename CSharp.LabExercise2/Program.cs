using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise2
{
    class Lasagna
    {
        int lasagnaOvenTime = 40;
        int timePerLayer = 2;

        public int ExpectedMinutesInOven()
        {
            return lasagnaOvenTime;
        }
        public int RemainingMinutesInOven(int timeInOven)
        {
            return ExpectedMinutesInOven() - timeInOven;
        }
        public int PreparationTimeInMinutes(int layers)
        {
            return timePerLayer * layers;
        }
        public int ElapsedTimeInMinutes(int layers, int timeInOven)
        {
            return PreparationTimeInMinutes(layers) + timeInOven;
        }
    }
    class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to the Number Array Printer");

            int counter = 0;
            int index = 0;
            int[] numbers = new int[5];
            do
            {
                Console.Write("\nPlease enter a number:");
                int input = Convert.ToInt32(Console.ReadLine());

                if(input >= 10 && input <= 100)
                {
                    if (Array.Exists(numbers, elements => elements == input))
                    {
                        PrintArrayItems(numbers);
                        Console.WriteLine("{0} Item already has been entered", input);
                    }
                    else
                    {
                        numbers[index] = input;
                        index++;
                        PrintArrayItems(numbers);
                    }
                    counter++;
                }
                else
                {
                    Console.WriteLine("Number must be betwen 10 and 100");
                }
            } while (counter < 5);
        }
        public static void PrintArrayItems(int[] input)
        {
            foreach(int item in input)
            {
                if(item != 0)
                {
                    Console.Write("{0} ", item);
                }
            }
            Console.WriteLine();
        }
        static void Number2()
        {
            Lasagna lasagna = new Lasagna();
            Console.WriteLine(lasagna.ExpectedMinutesInOven());
            Console.WriteLine(lasagna.RemainingMinutesInOven(30));
            Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
        }
        public static void Main(string[] args)
        {
            //Number1();
            Number2();
            
        }
    }
}
