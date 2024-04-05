using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDanielApril
{

    public class Store
    {

        //Here I store instances of other classes 
        private MenuCatalog menuCatalog = new MenuCatalog();
        private CustomerCatalog customerCatalog = new CustomerCatalog();
        private Order order = new Order();

        //Method to run the store app
        public void Run()
        {
            UserDialog userDialog = new UserDialog();

            // Create Pizza objects
            Pizza pizza1 = new Pizza { PizzaNo = 1, Name = "Margherita", Price = 90 };
            Pizza pizza2 = new Pizza { PizzaNo = 2, Name = "Hawaii", Price = 140 };
            Pizza pizza3 = new Pizza { PizzaNo = 3, Name = "Jordenrundt", Price = 250 };

            // Add Pizza objects to MenuCatalog
            menuCatalog.AddPizza(pizza1);
            menuCatalog.AddPizza(pizza2);
            menuCatalog.AddPizza(pizza3);

            //Infinite loop to display the menu 
            while (true)
            {
                //List of menu items displayed to the user 
                List<string> menuItems = new List<string>
            {
                "Add new pizza to the menu",
                "Delete pizza",
                "Update pizza",
                "Search pizza",
                "Display pizza menu",
                "Add new customer",
                "Delete customer",
                "Update customer",
                "Search customer",
                "Display customer list",
                "Add new order",
                "Add pizza to order",
                "Add extra topping to pizza",
                "Remove pizza from order",
                "Display order",
                "Exit"
            };
                //Telling the user to choose an option 
                int choice = userDialog.MenuChoice(menuItems);
                //Switch between different cases based on the users choice 
                switch (choice)
                {
                    case 1:
                        AddPizzaToMenu();
                        break;
                    case 2:
                        DeletePizzaFromMenu();
                        break;
                    case 3:
                        UpdatePizzaInMenu();
                        break;
                    case 4:
                        SearchPizzaInMenu();
                        break;
                    case 5:
                        DisplayPizzaMenu();
                        break;
                    case 6:
                        AddCustomer();
                        break;
                    case 7:
                        DeleteCustomer();
                        break;
                    case 8:
                        UpdateCustomer();
                        break;
                    case 9:
                        SearchCustomer();
                        break;
                    case 10:
                        DisplayCustomerList();
                        break;
                    case 11:
                        AddNewOrder();
                        break;
                    case 12:
                        AddPizzaToOrder();
                        break;
                    case 13:
                        AddExtraToppingToPizza();
                        break;
                    case 14:
                        RemovePizzaFromOrder();
                        break;
                    case 15:
                        DisplayOrder();
                        break;
                    case 16:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }
        //Method to add new pizza to the menu 
        private void AddPizzaToMenu()
        {
            Console.WriteLine("Enter pizza details:");
            Console.Write("Pizza No: ");
            int pizzaNo = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Pizza newPizza = new Pizza { PizzaNo = pizzaNo, Name = name, Price = price };
            menuCatalog.AddPizza(newPizza);
            Console.WriteLine("Pizza added to the menu.");
        }

        //Method to delete pizza from the menu 
        private void DeletePizzaFromMenu()
        {
            Console.WriteLine("Enter the pizza number to delete:");
            int pizzaNo = int.Parse(Console.ReadLine());

            Pizza pizzaToDelete = menuCatalog.SearchPizza(pizzaNo);
            if (pizzaToDelete != null)
            {
                menuCatalog.RemovePizza(pizzaToDelete);
                Console.WriteLine("Pizza deleted from the menu.");
            }
            else
            {
                Console.WriteLine("Pizza not found in the menu.");
            }
        }
        //Method to update details of pizza in the menu 
        private void UpdatePizzaInMenu()
        {
            Console.WriteLine("Enter the pizza number to update:");
            int pizzaNo = int.Parse(Console.ReadLine());

            Pizza pizzaToUpdate = menuCatalog.SearchPizza(pizzaNo);
            if (pizzaToUpdate != null)
            {
                Console.WriteLine("Enter updated details:");
                Console.Write("New Name: ");
                string newName = Console.ReadLine();
                Console.Write("New Price: ");
                decimal newPrice = decimal.Parse(Console.ReadLine());

                Pizza updatedPizza = new Pizza { PizzaNo = pizzaNo, Name = newName, Price = newPrice };
                menuCatalog.UpdatePizza(pizzaToUpdate, updatedPizza);
                Console.WriteLine("Pizza updated successfully.");
            }
            else
            {
                Console.WriteLine("Pizza not found in the menu.");
            }
        }
        //Method to search for pizza in menu 
        private void SearchPizzaInMenu()
        {
            Console.WriteLine("Enter the pizza number to search:");
            int pizzaNo = int.Parse(Console.ReadLine());

            Pizza foundPizza = menuCatalog.SearchPizza(pizzaNo);
            if (foundPizza != null)
            {
                Console.WriteLine($"Pizza No: {foundPizza.PizzaNo}, Name: {foundPizza.Name}, Price: {foundPizza.Price}");
            }
            else
            {
                Console.WriteLine("Pizza not found in the menu.");
            }
        }
        //Method to print entire pizza menu 
        private void DisplayPizzaMenu()
        {
            Console.WriteLine("Pizza Menu:");
            menuCatalog.PrintMenu();
        }
        //Method to add new customer 
        private void AddCustomer()
        {
            Console.WriteLine("Enter customer details:");
            Console.Write("Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Customer newCustomer = new Customer { CustomerId = customerId, Name = name };
            customerCatalog.AddCustomer(newCustomer);
            Console.WriteLine("Customer added successfully.");
        }
        //Method to delete customer 
        private void DeleteCustomer()
        {
            Console.WriteLine("Enter the customer ID to delete:");
            int customerId = int.Parse(Console.ReadLine());

            Customer customerToDelete = customerCatalog.SearchCustomer(customerId);
            if (customerToDelete != null)
            {
                customerCatalog.RemoveCustomer(customerToDelete);
                Console.WriteLine("Customer deleted successfully.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        //Method to update details of customer 
        private void UpdateCustomer()
        {
            Console.WriteLine("Enter the customer ID to update:");
            int customerId = int.Parse(Console.ReadLine());

            Customer customerToUpdate = customerCatalog.SearchCustomer(customerId);
            if (customerToUpdate != null)
            {
                Console.WriteLine("Enter updated details:");
                Console.Write("New Name: ");
                string newName = Console.ReadLine();

                Customer updatedCustomer = new Customer { CustomerId = customerId, Name = newName };
                customerCatalog.UpdateCustomer(customerToUpdate, updatedCustomer);
                Console.WriteLine("Customer updated successfully.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        //Method to search for customer by ID
        private void SearchCustomer()
        {
            Console.WriteLine("Enter the customer name to search:");
            string name = Console.ReadLine();

            Customer foundCustomer = customerCatalog.SearchCustomer(name);
            if (foundCustomer != null)
            {
                Console.WriteLine($"Customer ID: {foundCustomer.CustomerId}, Name: {foundCustomer.Name}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        //Method to dispaly the list of all customers 
        private void DisplayCustomerList()
        {
            Console.WriteLine("Customer List:");
            customerCatalog.PrintCustomers();
        }
        //Method to add new order 
        private void AddNewOrder()
        {
            Console.WriteLine("Enter customer ID for the new order:");
            int customerId = int.Parse(Console.ReadLine());
            Customer customer = customerCatalog.SearchCustomer(customerId);
            if (customer != null)
            {
                order = new Order { Customer = customer };
                Console.WriteLine("New order created.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }


        //Method to add pizza to the current order 
        private void AddPizzaToOrder()
        {
            Console.WriteLine("Enter the pizza number to add to the order:");
            int pizzaNo = int.Parse(Console.ReadLine());
            Pizza pizzaToAdd = menuCatalog.SearchPizza(pizzaNo);
            if (pizzaToAdd != null)
            {
                order.AddPizza(pizzaToAdd);
                Console.WriteLine("Pizza added to the order.");
            }
            else
            {
                Console.WriteLine("Pizza not found in the menu.");
            }
        }
        //Method to add extrea topping to pizza from my order
        private void AddExtraToppingToPizza()
        {
            Console.WriteLine("Enter the pizza number to add extra toppings:");
            int pizzaNo = int.Parse(Console.ReadLine());
            Pizza pizzaToUpdate = order.Pizzas.Find(p => p.PizzaNo == pizzaNo);
            if (pizzaToUpdate != null)
            {
                Console.WriteLine("Enter extra topping to add:");
                string topping = Console.ReadLine();
                order.AddExtraTopping(topping);
                Console.WriteLine("Extra topping added to the pizza.");
            }
            else
            {
                Console.WriteLine("Pizza not found in the order.");
            }
        }
        //Method to remove pizza from order 
        private void RemovePizzaFromOrder()
        {
            Console.WriteLine("Enter the pizza number to remove from the order:");
            int pizzaNo = int.Parse(Console.ReadLine());
            Pizza pizzaToRemove = order.Pizzas.Find(p => p.PizzaNo == pizzaNo);
            if (pizzaToRemove != null)
            {
                order.RemovePizza(pizzaToRemove);
                Console.WriteLine("Pizza removed from the order.");
            }
            else
            {
                Console.WriteLine("Pizza not found in the order.");
            }
        }
        //Method to display details of my current order 
        private void DisplayOrder()
        {
            Console.WriteLine("Order:");
            Console.WriteLine($"Customer: {order.Customer.Name}");
            Console.WriteLine("Pizzas:");
            foreach (var pizza in order.Pizzas)
            {
                Console.WriteLine($"Pizza No: {pizza.PizzaNo}, Name: {pizza.Name}, Price: {pizza.Price}");
            }
            Console.WriteLine("Extra Toppings:");
            foreach (var topping in order.ExtraToppings)
            {
                Console.WriteLine(topping);
            }
        }
    }





}
