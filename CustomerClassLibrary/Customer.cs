using System;
using System.Collections.Generic;

namespace CustomerInformationSystem
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string customerEmail;
        private string customerPhone;
        private string customerAddress;


        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }


        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        //default constructor
        /// <summary>
        /// //This method returns the customer name for provided customer Id. Will return null if not found.
        /// <param name ="customers"></param>
        /// <param name = "CustomerId"></param> 
        /// </summary>
        public Customer()
        {
            //do nothing
        }

        // This method return the customer name for provided customer ID> It return null if it is not found
            
       
        public string GetCustomer(List<Customer> customers, int customerId)
        {
            foreach (Customer c in customers)
            {
                if(c.CustomerId == customerId)
                {
                    return c.CustomerName;
                }

            }
            //If no customer found reutrn null
            return null;
        }

        public int GetCustomer(List<Customer> customers, string customerName)
        {
            foreach (Customer c in customers)
            {
                //Convert both strings to upper case before comparing
                if (c.CustomerName.ToUpper() == customerName.ToUpper())
                {
                    return c.CustomerId;
                }

            }
            //If no customer found return 0
            return 0;
        }

    }


    public class Product
    {
        private int productId;
        private string productName;
        private string productCategory;
        private string productDescription;
        private decimal productPrice;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public decimal ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public Product()
        {
            //do nothing
        }

        public string GetProduct(List<Product> products, int productId)
        {
            foreach (Product p in products)
            {
                if (p.ProductId == productId)
                {
                    return p.ProductName;
                }

            }
            //If no product found return null
            return null;
        }

        public int GetProduct(List<Product> products, string productName)
        {
            foreach (Product p in products)
            {
                //Convert both strings to upper case before comparing
                if (p.ProductName.ToUpper() == productName.ToUpper())
                {
                    return p.ProductId;
                }

            }
            //If no product found return null
            return 0;
        }
    }

    public class Sale
    {
        private int customerId;
        private int productId;
        private decimal purchasePrice;
       


        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }

        public decimal TotalSalesByProduct (List<Sale> sales, int productId)
        {
            decimal totalSales = 0.0m;

            foreach (Sale s in sales)
            {
                if(s.ProductId == productId)
                {
                    totalSales = totalSales + s.PurchasePrice;
                }
            }

            return totalSales;
        }

        public decimal TotalSalesByCustomer(List<Sale> sales, int customerId)
        {
            decimal totalSales = 0.0m;

            foreach (Sale s in sales)
            {
                if (s.customerId == customerId)
                {
                    totalSales = totalSales + s.PurchasePrice;
                }
            }

            return totalSales;
        }


    }





}
