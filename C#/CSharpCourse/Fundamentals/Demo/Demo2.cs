using System;

namespace CSharpCourse.Fundamentals.Demo
{
    public class Demo2
    {
        public void Run()
        {
            Console.Write("Enter your weight in kilo: ");
            string answer = Console.ReadLine();
            decimal kilo = decimal.Parse(answer);
            decimal ton = kilo / 1000;
            string response = "You weight is " + ton + " ton";
            //string response = $"You weight is {ton} ton";
            //string response = string.Format("You weight is {0}", ton);
            Console.WriteLine(response);
        }
    }
}
