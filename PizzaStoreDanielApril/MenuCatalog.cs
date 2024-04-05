using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDanielApril
{

    public class MenuCatalog
    {
        //List to store pizzas
        private List<Pizza> pizzas = new List<Pizza>();

        //Method to add a pizza to the menu
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        //Method to remove a pizza from the menu
        public void RemovePizza(Pizza pizza)
        {
            pizzas.Remove(pizza);
        }

        //Method to update a pizza in the menu
        public void UpdatePizza(Pizza pizzaToUpdate, Pizza newPizza)
        {
            //Find the index of the pizza to update in the list
            int index = pizzas.FindIndex(p => p.PizzaNo == pizzaToUpdate.PizzaNo);
            //If the pizza is found, it is to be updated with a new pizza
            if (index != -1)
            {
                pizzas[index] = newPizza;
            }
        }
        //Method to print the menu with pizza 
        public void PrintMenu()
        {
            //Going through each pizza in the menu and print its details
            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"Pizza No: {pizza.PizzaNo}, Name: {pizza.Name}, Price: {pizza.Price}");
            }
        }
        //Method to search for a pizza in the menu by its pizza number
        public Pizza SearchPizza(int pizzaNo)
        {
            //Return the pizza with the specified pizza number if it is found. 
            return pizzas.Find(p => p.PizzaNo == pizzaNo);
        }
    }


}
