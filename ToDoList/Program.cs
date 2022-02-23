using System;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Action<string> cwl = Console.WriteLine;
      Action<string> cw = Console.Write;

      cwl("Welcome to the To Do List!");

      while (true)
      {
        cwl("Would you like to add an item to your list or view your list? (Add/View/Clear/Quit)");
        cw("ACTION: ");

        string action = Console.ReadLine().ToUpper();

        switch (action)
        {
          case "ADD":
            cwl("Please enter the description for the new item:");
            string description = Console.ReadLine();
            Item item = new Item(description);
            cw($"'{description}' has been added to your list. ");
            break;
          case "VIEW":
            int counter = 1;
            cwl("ITEMS:");
            foreach(Item i in Item.GetAll())
            {
              cwl($"    {counter}: " + i.Description);
              counter += 1;
            }
            break;
          case "CLEAR":
            cw("Are you sure you'd like to clear your list? [YES/NO] ");
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
              case "YES":
                Item.ClearAll();
                cwl("Your items have been cleared.");
                break;
              case "NO":
                cwl("Phew, that was a close one!");
                break;
              default:
                cwl("I did not understand the command.");
                break;
            }
            break;
          case "QUIT":
            cwl("Have a great day!\n");
            return;
          default:
            cwl("I did not understand the command.");
            break;
        }
      }
    }
  }
}
