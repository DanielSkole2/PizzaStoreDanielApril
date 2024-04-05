using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDanielApril
{

    public class UserDialog
    {
        //Method to present a menu of options to the user and get their choice 
        public int MenuChoice(List<string> menuItems)
        {
            //Variable to store the users choice
            int choice = -1;
            //Check if the users choice is valid
            bool validChoice = false;

            //Loop until the user makes a valid choice 
            while (!validChoice)
            {
                Console.WriteLine("Please choose an option:");
                //Display each menu item along with its corresponding number 
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }
                //Get user input and try to parse it as an int 
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    //Check if the parsed int corresponds to a valid menu item 
                    if (choice >= 1 && choice <= menuItems.Count)
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and " + menuItems.Count);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return choice;
        }
    }



}
