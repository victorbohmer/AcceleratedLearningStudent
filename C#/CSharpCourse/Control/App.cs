﻿using System;

namespace CSharpCourse.Control
{
    public class App
    {
        public void Run()
        {
            //new Demo.Demo1().Run();
            //new Demo.Demo2().Run();
            //new Demo.Demo3().Run();
            //DemoLoops.App.Nested1();
            //DemoLoops.App.Nested2();
            //DemoLoops.App.Nested2_While();
            //DemoLoops.App.Nested3(3,6);
            //DemoLoops.App.Nested4(2,100);

            //DoYouNeedToSleep();
            DoYouNeedToSleep_WithTimespan();
            //RepeatNameWithWhile();
            //RepeatNameWithFor();
            //SplitAndForeach();
            //SplitAndForeach_WithBreak();
            //IfStatement();
            //IfConditional();
        }

        private void DoYouNeedToSleep_WithTimespan()
        {
            Console.Write("When did you go to bed yesterday? ");
            TimeSpan toSleep = TimeSpan.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            TimeSpan wokeUp = TimeSpan.Parse(Console.ReadLine());

            if (toSleep > wokeUp)
                wokeUp = wokeUp.Add(TimeSpan.FromDays(1));

            double sleepTime = (wokeUp - toSleep).TotalHours;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            if (sleepTime < 6)
            {
                Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
            }
            else if (sleepTime > 12)
            {
                Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
            }
            else
            {
                Console.WriteLine($"You have slept well. ({sleepTime} hours)");
            }
        }

        // If statement

        public void DoYouNeedToSleep()
        {
            // 21 6      (24-21) + 6             6 - 21 + 24
            // 22 6      (24-22) + 6             6 - 22 + 24
            // 23 6      (24-23) + 6             6 - 23 + 24
            // 0  6      6 - 0                   6 - 0 
            // 1  6      6 - 1                   6 - 1

            Console.Write("When did you go to bed yesterday? ");
            int toSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wokeUp = int.Parse(Console.ReadLine());

            int sleepTime;

            if (toSleep > wokeUp)
                sleepTime = wokeUp + (24 - toSleep);
            else
                sleepTime = wokeUp - toSleep;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            if (sleepTime < 6)
                Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
            else if (sleepTime > 12)
                Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
            else
                Console.WriteLine($"You have slept well. ({sleepTime} hours)");

            // Alternative with switch-when:

            //switch (sleepTime)
            //{
            //    case int n when n < 6:
            //        Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
            //        break;
            //    case int n when n > 12:
            //        Console.WriteLine($"You've slept {sleepTime} hours. That's a lot."); 
            //        break;
            //    default:
            //        Console.WriteLine($"You have slept well. ({sleepTime} hours)");
            //        break;
            //}

        }

        //  While loop

        public void RepeatNameWithWhile()
        {
            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            int counter = 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            while (counter <= repeat)
            {
                Console.WriteLine($"Your name is {yourName}");
                counter++;
            }

        }

        // For loop

        public void RepeatNameWithFor()
        {

            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            for (int counter = 0; counter < repeat; counter++)
            {
                Console.WriteLine($"Your name is {yourName}");
            }

        }

        //  Foreach loop 

        public void SplitAndForeach()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine();

            string[] nameList = names.Split(",", StringSplitOptions.RemoveEmptyEntries);
            //string[] nameList = names.Split(",");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }
        }

        // Foreach with break

        public void SplitAndForeach_WithBreak()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(",", StringSplitOptions.RemoveEmptyEntries);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in nameList)
            {
                if (name == "Zelda")
                {
                    break;
                }

                Console.WriteLine($"{name} Andersson");
            }
        }

        // If statement

        public void IfStatement()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string message;
            if (number > 20)
            {
                message = "The number is higher than 20";
            }
            else
            {
                message = "Lower or equal to 20";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(message);
        }

        // Conditional if statement

        public void IfConditional()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string message = (number > 20) ? "The number is higher than 20" : "Lower or equal to 20";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(message);
        }

    }
}
