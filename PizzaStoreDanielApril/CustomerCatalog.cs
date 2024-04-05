using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDanielApril
{

    public class CustomerCatalog
    {
        //List to store customer item
        private List<Customer> customers = new List<Customer>();
        //Method to add customer 
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        //Method to remove customer 
        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
        //Method to update details of cuistomer 
        public void UpdateCustomer(Customer customerToUpdate, Customer newCustomer)
        {
            int index = customers.FindIndex(c => c.CustomerId == customerToUpdate.CustomerId);
            if (index != -1)
            {
                customers[index] = newCustomer;
            }
        }
        //Method to search for customer by their id
        public Customer SearchCustomer(int customerId)
        {
            return customers.Find(c => c.CustomerId == customerId);
        }
        //Method to search for customer by their name
        public Customer SearchCustomer(string name)
        {
            return customers.Find(c => c.Name == name);
        }
        //Method to print the list of customers 
        public void PrintCustomers()
        {
            //Print each customer in the list and their details 
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.Name}");
            }
        }
    }







}
