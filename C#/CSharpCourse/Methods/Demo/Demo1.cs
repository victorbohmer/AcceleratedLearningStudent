﻿using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo1
    {
        public void Run()
        {
            Console.Write("When do start working in the morning? ");
            string startString = Console.ReadLine();
            TimeSpan start = TimeSpan.Parse(startString);

            Console.Write("When do you go for lunch? ");
            string lunchString = Console.ReadLine();
            TimeSpan lunch = TimeSpan.Parse(lunchString);

            Console.Write("When does your lunch end? ");
            string lunchEndString = Console.ReadLine();
            TimeSpan lunchEnd = TimeSpan.Parse(lunchEndString);

            Console.Write("When do you go home from work? ");
            string endString = Console.ReadLine();
            TimeSpan end = TimeSpan.Parse(endString);

            Console.WriteLine();
            TimeSpan worktime = lunch - start + end - lunchEnd;
            Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes" );

        }
    }
}
