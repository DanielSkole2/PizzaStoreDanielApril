using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDanielApril
{

    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<string> ExtraToppings { get; set; }

        //Constructor to start the order with empty lists for pizzas and extra toppings 
        public Order()
        {
            
            Pizzas = new List<Pizza>();
            ExtraToppings = new List<string>();
        }
        //Method to add a pizza to the order
        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }
        //Method to add extra topping to pizza in my order 
        public void AddExtraTopping(string topping)
        {
            ExtraToppings.Add(topping);
        }
        //Pizza to remove pizza from the order 
        public void RemovePizza(Pizza pizza)
        {
            Pizzas.Remove(pizza);
        }
        //Method to update details of a pizza in the order 
        public void UpdatePizza(Pizza pizzaToUpdate, Pizza newPizza)
        {
            int index = Pizzas.FindIndex(p => p.PizzaNo == pizzaToUpdate.PizzaNo);
            if (index != -1)
            {
                Pizzas[index] = newPizza;
            }
        }
    }






}
