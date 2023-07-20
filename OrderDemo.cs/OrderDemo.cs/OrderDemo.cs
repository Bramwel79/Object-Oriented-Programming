using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderDemo.cs
{
    class OrderDemo
    {
        static void Main(string[] args)
        {
            Order aristoteles = new Order(1233,"single",1);
            Order olympicStar = new Order(3553, "double", 4);
            Order georgios = new Order(1233, "single",1);
            Console.WriteLine(aristoteles.ToString());
            Console.WriteLine();
            Console.WriteLine(olympicStar.ToString());
            Console.WriteLine();
            Console.WriteLine(georgios.ToString());
            Console.WriteLine();
            CompareOrders(aristoteles, olympicStar);
            Console.WriteLine();
            CompareOrders(aristoteles, georgios);
            Console.ReadLine();


        }
        public static void CompareOrders(Order one, Order two)
        {
            if (one.Equals(two))
            {
                Console.WriteLine("The two orders are equal");
                Console.WriteLine("************************");
                Console.WriteLine("Order Number " + one.OrderNumber  + " is equal to " + two.OrderNumber );
                Console.WriteLine("Customer Name " + one.CustomerName + " is equal to " + two.CustomerName);
                Console.WriteLine("Quantity Ordered " + one.QuantityOrdered + " is equal to " + two.QuantityOrdered);
            }
            else
                Console.WriteLine("The two oders are not equal");
        }
    }

    public class Order
    {
        const double UNIT_PRICE = 19.95;
        int orderNumber;
        string customerName;
        int quantityOrdered;
        double totalPrice;
        public Order(int numOrder, string name, int quantity)
        {
            OrderNumber  = numOrder;
            CustomerName  = name;
            QuantityOrdered  = quantity;

        }
        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }
            set
            {
                orderNumber = value;
            }

        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public int QuantityOrdered
        {
            get
            {
                return quantityOrdered;
            }
            set
            {
                quantityOrdered = value;
                totalPrice = quantityOrdered * UNIT_PRICE;
            }
        }
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public override bool Equals(object o)
        {
            bool equal;
            Order  temp;
            temp = (Order)o;
            if (OrderNumber == temp.OrderNumber)
                equal = true;
            else
                equal = false;
            return equal;

        }
        public override int GetHashCode()
        {
            return OrderNumber;
        }
        public override string ToString()
        {
            return ("The order number is " + OrderNumber + "\nCustomer name is " + CustomerName +
                "\nQuantity ordered is " + QuantityOrdered +
                "\nTotal price is " + TotalPrice);
        }
    }
}
