using System;

namespace CSharpCourse.Fundamentals.Demo
{
    public class Demo3
    {
        public void Run()
        {
            Console.Write("Enter your weight in kilo: ");
            string answer = Console.ReadLine();
            decimal kilo = decimal.Parse(answer);

            if (kilo<0)
                Console.WriteLine("You're probably dead");
            else if (kilo>100)
                Console.WriteLine("You weigh more than 100 kilo" );
            else
                Console.WriteLine("You weigh less than 100 kilo");

        }
    }
}
