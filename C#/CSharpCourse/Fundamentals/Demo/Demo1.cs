using System;

namespace CSharpCourse.Fundamentals.Demo
{
    public class Demo1
    {
        public void Run()
        {
            Console.Write("Enter your weight in kilo: ");
            string answer = Console.ReadLine();

            Console.WriteLine("You weight is " + answer + " kilo");
        }
    }
}
