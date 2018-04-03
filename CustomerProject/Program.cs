using System;
using System.Collections.Generic;
using static System.Console;
using CustomerInformationSystem;

namespace CustomerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set data for customers
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId=101, CustomerName="John Doe", CustomerEmail="johndoe@wichita.edu", CustomerPhone="316-123-1234", CustomerAddress="1702 Fairmount"},
                new Customer { CustomerId=102, CustomerName="Adam Crabtree", CustomerEmail="adamcrabtree@wichita.edu", CustomerPhone="316-123-5678", CustomerAddress="1822 Fairmount"},
                new Customer { CustomerId=103, CustomerName="Mary Jane", CustomerEmail="maryjane@wichita.edu", CustomerPhone="316-123-9090", CustomerAddress="1413 Mulberry Drive"},
                new Customer { CustomerId=104, CustomerName="Joe Dirt", CustomerEmail="joedirt@wichita.edu", CustomerPhone="316-911-5050", CustomerAddress="542 Donut Drive"}

            };

            //Set data for products
            List<Product> products = new List<Product>
            {
                new Product { ProductId=201, ProductName="ProductX", ProductCategory="Category1", ProductDescription="Product X dummy description", ProductPrice=19.99m},
                new Product { ProductId=202, ProductName="ProductY", ProductCategory="Category2", ProductDescription="Product Y dummy description", ProductPrice=25.99m},
                new Product { ProductId=202, ProductName="ProductZ", ProductCategory="Category3", ProductDescription="Product Z dummy description", ProductPrice=24.99m }
            };

            //Set data for sales
            List<Sale> sales = new List<Sale>
            {
                new Sale { CustomerId=101, ProductId=201, PurchasePrice=19.99m},
                new Sale { CustomerId=101, ProductId=202, PurchasePrice=25.99m},
                new Sale { CustomerId=102, ProductId=201, PurchasePrice=19.99m},
                new Sale { CustomerId=102, ProductId=202, PurchasePrice=25.99m},
                new Sale { CustomerId=103, ProductId=201, PurchasePrice=19.99m}
            };


            WriteLine("Options (by letter):");
            WriteLine("A. Search customer by ID");
            WriteLine("B. Search customer by name");
            WriteLine("C. Please enter an option.");
            WriteLine("D. Search product by name.");
            WriteLine("E. Calculate total sales by product.");
            WriteLine("F. Calculate total sales for customer by entering name.");
            
            try
            {
                string option = Console.ReadLine();

                if (option == "A" || option == "a")
                {
                    string customerName;
                    WriteLine("Enter customer ID");
                    int customerId = Convert.ToInt32(Console.ReadLine());

                    Customer c = new Customer();

                    customerName = c.GetCustomer(customers, customerId);
                    WriteLine($"Customer Name: {customerName} ");


                }
                else if (option == "B" || option == "b")
                {
                    int customerId;
                    WriteLine("Enter customer Name");
                    string customerName = (Console.ReadLine());

                    Customer c = new Customer();

                    customerId = c.GetCustomer(customers, customerName);
                    WriteLine($"Customer ID: {customerId} ");
                }

                else if (option == "C" || option == "c")
                {
                    string productName;
                    WriteLine("Enter product ID");
                    int productId = Convert.ToInt32(Console.ReadLine());

                    Product p = new Product();

                    productName = p.GetProduct(products, productId);
                    WriteLine($"Product name: {productName} ");
                }
                else if (option == "D" || option == "d")
                {
                    int productId;
                    WriteLine("Enter product Name");
                    string productName = (Console.ReadLine());

                    Product p = new Product();

                    productId = p.GetProduct(products, productName);
                    WriteLine($"Product ID: {productId} ");
                }

                else if (option == "E" || option == "e")
                {
                    decimal totalSales;
                    WriteLine("Enter product ID");
                    int pID = Convert.ToInt32(Console.ReadLine());

                    Sale s = new Sale();

                    totalSales = s.TotalSalesByProduct(sales, pID);
                    WriteLine($"Sales Total: {totalSales} ");
                }
                else if (option == "F" || option == "f")
                {
                    decimal totalSales;
                    WriteLine("Enter customer ID");
                    int cID = Convert.ToInt32(Console.ReadLine());

                    Sale s = new Sale();

                    totalSales = s.TotalSalesByCustomer(sales, cID);
                    WriteLine($"Sales Total: {totalSales} ");
                }
            }
            catch (FormatException)
            {
                WriteLine("Invalid data type.");
            }
            catch (OverflowException)
            {
                WriteLine("Overflow Exception");
            }
            catch
            {
                WriteLine("Error: Layer 8 issue");
            }
        }

        
    }
}
