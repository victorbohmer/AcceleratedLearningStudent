﻿using CSharpCourse.Utilities;
using System.Collections.Generic;

namespace CSharpCourse.Collections
{
    public class ListLab
    {
        ConsoleHelper ch = new ConsoleHelper();


        public void NamesWithListManipulate()
        {
            var list = new List<string>();

            while (true)
            {
                string name = ch.AskForString("Enter a name:");
                if (name.ToLower() == "quit")
                {
                    list.Sort();

                    if (list.Count == 1)
                        list.RemoveAt(0);

                    else if (list.Count >= 2)
                    {
                        list.RemoveAt(0);
                        list.RemoveAt(list.Count - 1);
                    }
                    DisplayPeople(list);
                    return;
                }
                list.Add(name);
            }
        }


        private void ThreeNamesWithArray()
        {
            var list = new string[3];

            for (int i = 0; i < 3; i++)
            {
                string name = ch.AskForString("Enter a name:");
                list[i] = name;
            } 

            DisplayPeople(list);
        }

        private void ThreeNamesWithList()
        {
            var list = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                string name = ch.AskForString("Enter a name:");
                list.Add(name);
            }
            DisplayPeople(list);
        }

        private void NamesWithList()
        {
            var list = new List<string>();

            while(true)
            {
                string name = ch.AskForString("Enter a name:");
                if (name.ToLower() == "quit")
                {
                    DisplayPeople(list);
                    return;
                }
                list.Add(name);
            }
        }

        private void DisplayPeople(string[] list)
        {
            foreach (var name in list)
            {
                ch.WriteLineDark($"Name: {name}");
            }
        }

        private void DisplayPeople(List<string> list)
        {
            foreach (var name in list)
            {
                ch.WriteLineDark($"Name: {name}");
            }
        }
    }
}
