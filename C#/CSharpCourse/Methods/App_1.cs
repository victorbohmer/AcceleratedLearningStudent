using System;

namespace CSharpCourse.Methods
{
    public class App_1
    {
        public void Run()
        {
            string response = GetInputFromUser();

            string[] peopleArray = CreateArrayOfPeople(response);

            RespondToUser(peopleArray);
        }

        private string GetInputFromUser()
        {
            Write("Enter a list of names: ");
            string answer = Console.ReadLine();

            return answer;
        }

        private string[] CreateArrayOfPeople(string response)
        {
            if (string.IsNullOrWhiteSpace(response))
                return new string[] { };

            string[] list = response.Split(',');

            return list;
        }

        private void RespondToUser(string[] peopleArray)
        {
            if (peopleArray.Length == 0)
            {
                WriteGreen("No people in the list");
                return;
            }

            foreach (string person in peopleArray)
            {
                WriteGreen($"***SUPER-{person.ToUpper()}***");
            }
        }


        private void WriteGreen(object message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        private void Write(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }
    }
}
