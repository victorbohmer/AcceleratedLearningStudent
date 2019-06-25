﻿// Same as Demo1.cs but without "while(true)"
using System;

namespace CSharpCourse.Control.Demo
{
    public class Demo2
    {
        public void Run()
        {
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("Enter your favorite color: ");
                string answer = Console.ReadLine();

                if (answer == "green" || answer == "blue" || answer == "red")
                {
                    Console.WriteLine($"You like the color {answer}");
                    validAnswer = true;
                }
                Console.WriteLine("I don't know that color, try again");
            }
        }
    }
}
