﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace S6_HK1B_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("You have 5 chances to guess the correct number.");

            Console.WriteLine("Please select the difficulty level:");
            Console.WriteLine("1.Easy(10 chances)");
            Console.WriteLine("2.Medium(5 chances)");
            Console.WriteLine("3.Hard(3 chances)");

            // CamelCase
            int difficultyLevel = int.Parse(Console.ReadLine());

            int chances = 0;

            switch (difficultyLevel)
            {
                case 1:
                    chances = 10;
                    break;
                case 2:
                    chances = 5;
                    break;
                case 3:
                    chances = 3;
                    break;
                default:
                    Console.WriteLine("Invalid difficulty level.");
                    break;
            }

            Random random = new Random();
            int correctNumber = random.Next(100, 1000);

            while (chances > 0)
            {
                Console.WriteLine("Please enter your guess:");
                int guess = int.Parse(Console.ReadLine());

                if (guess == correctNumber)
                {
                    Console.WriteLine("Congratulations! You have guessed the correct number.");
                    break;
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("The correct number is greater than your guess.");
                }
                else
                {
                    Console.WriteLine("The correct number is less than your guess.");
                }

                chances--;
                Console.WriteLine($"You have {chances} chances left.");
            }

            if (chances == 0)
            {
                Console.WriteLine($"You have run out of chances. The correct number is {correctNumber}.");
            }

            Console.ReadLine();
        }
    }
}
