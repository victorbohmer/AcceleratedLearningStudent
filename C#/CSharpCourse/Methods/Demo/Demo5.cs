// Less repetition
using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo5
    {
        public void Run()
        {
            double triangle1Height = GetPositiveNumber("Enter height of triangle1: "); 
            double triangle1Width = GetPositiveNumber("Enter width of triangle1: ");

            double triangle2Height = GetPositiveNumber("Enter height of triangle2: ");
            double triangle2Width = GetPositiveNumber("Enter width of triangle2: ");

            double area1 = AreaOfTriangle(triangle1Height, triangle1Width);
            double area2 = AreaOfTriangle(triangle2Height, triangle2Width);

            ReportArea(1, area1);
            ReportArea(2, area2);

        }

        private double GetPositiveNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                double num;
                if (double.TryParse(answer, out num) && num > 0)
                    return num;
            }
        }

        private double AreaOfTriangle(double triangleHeight, double triangleWidth)
        {
            return triangleHeight * triangleWidth / 2; 
        }

        private void ReportArea(int triangleNumber, double area)
        {
            Console.WriteLine($"Area of triangle {triangleNumber} is: {area}");
        }
    }
}
