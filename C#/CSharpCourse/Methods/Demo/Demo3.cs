// Added validation so you can't enter to early times
using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo3
    {
        public void Run()
        {
            TimeSpan start = AskForTime("When do start to work in the morning?", null);
            TimeSpan lunch = AskForTime("When do you go for lunch?", start);
            TimeSpan lunchEnd = AskForTime("When does your lunch end?", lunch);
            TimeSpan end = AskForTime("When do you go home from work?", lunchEnd);

            TimeSpan worktime = CalculateWorkTime(start, lunch, lunchEnd, end);

            Console.WriteLine();
            Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");

        }

        private TimeSpan CalculateWorkTime(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
        {
            return lunch - start + end - lunchEnd;
        }

        private TimeSpan AskForTime(string question, TimeSpan? mustBeLaterThan)
        {
            while (true)
            {
                Console.Write(question + " ");
                string answer = Console.ReadLine();
                TimeSpan time;
                bool success = TimeSpan.TryParse(answer, out time);
                if (success)
                {
                    if (mustBeLaterThan == null || time > mustBeLaterThan)
                        return time;
                }
            }
        }
    }
}
