using System;
using System.Collections.Generic;

namespace CSharpCourse.Methods
{
    public class App_4
    {
        public void Run()
        {
            string[] peopleArray;

            char separator = AskUserForSeparator();
            bool wantErrorMessage = AskUserForErrorMessage();

            while (true)
            {
                string response = GetInputFromUser();
                peopleArray = CreateArrayOfPeople(response, separator);
                CleanUpArray(peopleArray);

                if (PeopleArrayIsValid(peopleArray, wantErrorMessage))
                    break;
            }

            RespondToUser(peopleArray);
        }

        private char AskUserForSeparator()
        {
            char separator;
            bool parseSuccess;

            do
            {
                Write("Which separator do you want to use (default is comma) ? ");
                string answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                    answer = ",";
                }

                parseSuccess = char.TryParse(answer, out separator);
            } while (!parseSuccess);

            return separator;
        }

        private bool AskUserForErrorMessage()
        {
            bool wantErrorMessage = false;
            while (true)
            {
                Write("Do you want to see error messages (default is yes) ? ");
                string answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                    answer = "yes";
                }
                answer = answer.ToLower();

                if (answer == "yes")
                {
                    wantErrorMessage = true;
                    break;
                }
                if (answer == "no")
                    break;

            }

            return wantErrorMessage;
        }

        private string GetInputFromUser()
        {
            Console.Write("Enter a list of names: ");
            string answer = Console.ReadLine();

            return answer;
        }

        private string[] CreateArrayOfPeople(string response, char separator = ',')
        {
            if (string.IsNullOrWhiteSpace(response))
                return new string[] { };

            string[] list = response.Split(separator);

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

        private void CleanUpArray(string[] peopleArray)
        {
            for (var i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = peopleArray[i].Trim();
            }
        }


        private string[] CleanUpArray_Alternative(string[] list)
        {
            List<string> x = new List<string>();

            foreach (var element in list)
            {
                var cleanedElement = element.Trim();
                x.Add(cleanedElement);
            }

            return x.ToArray();
        }

        private bool PeopleArrayIsValid(string[] peopleArray, bool respondToUser = false)
        {
            if (peopleArray.Length == 0)
            {
                if (respondToUser)
                    ErrorMessage("The list don't contain any names");

                return false;
            }

            foreach (string person in peopleArray)
            {
                if (person.Length <= 1 || person.Length >= 10)
                {
                    if (respondToUser)
                        ErrorMessage("A person can only have 2 to 9 letters");

                    return false;
                }
            }
            return true;
        }

        private void WriteGreen(object message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }


        private void ErrorMessage(object message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        private void Write(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }
    }
}
