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
        cwl("Would you like to add an item to your list or view your list? (Add/View/Quit)");
        cw("ACTION: ");

        string action = Console.ReadLine().ToUpper();

        switch (action)
        {
          case "ADD":
            cwl("You've added something!\n");
            break;
          case "VIEW":
            cwl("You're looking at stuff!\n");
            break;
          case "QUIT":
            cwl("Have a great day!\n");
            return;
        }
      }
    }
  }
}
