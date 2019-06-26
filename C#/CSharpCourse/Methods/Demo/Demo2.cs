// Better with "AskForTime". Less repetition
using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo2
    {
        public void Run()
        {
            TimeSpan start = AskForTime("When do you start to work in the morning?");
            TimeSpan lunch = AskForTime("When do you go for lunch?");
            TimeSpan lunchEnd = AskForTime("When does your lunch end?");
            TimeSpan end = AskForTime("When do you go home from work?");

            ReportWorkingHours(start, lunch, lunchEnd, end);

        }

        private void ReportWorkingHours(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            TimeSpan worktime = lunch - start + end - lunchEnd;
            Console.WriteLine();

            Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");
        }

        private TimeSpan AskForTime(string question)
        {
            Console.Write(question + " ");
            string answer = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(answer);
            return time;
        }
    }
}
