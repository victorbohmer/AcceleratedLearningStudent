// Difference between array and lists. Common methods.
using System.Collections.Generic;

namespace CSharpCourse.Collections.Demo
{
    public class Demo1
    {
        public void Run()
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            int nrOfElements = salmons.Count; // 4
            string firstElement = salmons[0]; // chinook
            string thirdElement = salmons[2]; // pink

            salmons.Remove("pink");
            nrOfElements = salmons.Count;   // 3

            List<int> importantYears = new List<int> { 570, 1492, 1789 };
            importantYears.Add(1917);
            int count1 = importantYears.Count; // 4

            int[] importantYears_Array = new[] { 570, 1492, 1789 };
            int count2 = importantYears_Array.Length; // 3
            // importantYears_Array.Add(1917); // doesn't work
        }
    }
}
