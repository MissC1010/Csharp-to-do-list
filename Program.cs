using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program");
            Console.WriteLine("Made by Celina ♥");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter the name of task to add to list");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {taskList[i]}");
                    }

                    Console.WriteLine("Enter the number of the task you want to remove");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list:");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");

                }
                else
                {
                    Console.WriteLine("invalid option, please try again");
                }

            }
            Console.WriteLine($"Thank you for using the program");

        }
    }
}
