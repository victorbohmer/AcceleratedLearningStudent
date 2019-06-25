using System;

namespace CSharpCourse.Control.Demo
{
    public class Demo3
    {
        public void Run()
        {
            string[] planets = new[] { "Mercury", "Venus", "Earth", "Mars" };

            foreach (string  p in planets)
            {
                Console.WriteLine(p);
            }

            int[] importantYears = new[] { 570, 1492, 1789, 1917 };

            foreach (int year in importantYears)
            {
                Console.WriteLine(year);
            }

            for (int i = 10; i <= 20; i++)
            {
                if (i == 15)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
