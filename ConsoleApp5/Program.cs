using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var toDoList = new List<string> { "Clean", "Workout", "Code" };

            while (running)
            {
                Console.WriteLine("Here's your current todo list: ");
                PrintToDoList(toDoList);

                Console.WriteLine("\n What would you like to do? \n 1) Complete an item. \n 2) Add an item \n 3) Edit an item? \n 4) Exit");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    CompleteAnItem(toDoList);
                }
                else if (action == "2")
                {
                    AddNewItem(toDoList);
                }
                else if (action == "3")
                {
                    EditItem(toDoList);
                }
                else if (action == "4")
                {
                    Console.WriteLine("Exiting...");
                    running = false;
                }
                else Console.WriteLine("Whoops, looks like that's not a valid choice. Try again.");
            }
        }

        static void PrintToDoList(List<string> toDoList)
        {
            int i = 0;
            foreach (string item in toDoList)
            {
                Console.WriteLine($"{i+1}) {item}");
                i++;
            }
        }

        static void CompleteAnItem(List<string> toDoList)
        {
            Console.WriteLine("Enter the number of the item you want to complete:");
            string itemIndexToComlete = Console.ReadLine();
            toDoList.RemoveAt(Int32.Parse(itemIndexToComlete) - 1);
            Console.WriteLine("Item completed. Good job!");
        }

        static void AddNewItem(List<string> toDoList)
        {
            Console.WriteLine("Enter a new item for your todo list:");
            string newItem = Console.ReadLine();
            toDoList.Add(newItem);
            Console.WriteLine($"Added {newItem}.");
        }

        static void EditItem(List<string> toDoList)
        {
            try
            {
                Console.WriteLine("Enter the number of the item you'd like to edit:");
                string itemToEdit = Console.ReadLine();
                Console.WriteLine("What would you like to change it to?");
                string editedItem = Console.ReadLine();

                toDoList[Int32.Parse(itemToEdit) - 1] = editedItem;
                Console.WriteLine("Your list has been updated.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Looks like that wasn't valid. Try again");
                EditItem(toDoList);
            }
        }

    }
}
