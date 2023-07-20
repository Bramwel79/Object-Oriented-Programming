using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderDemo2.cs
{
    class OrderDemo2
    {
        static void Main(string[] args)
        {
            bool numberOK = false ;
            int x;
            int y;
            double totalOrders = 0;
            Order[] orders = new Order[5];
            //get input from client
            for ( x = 0; x < orders.Length; ++x)
            {
                orders[x] = new Order();
                Console.Write("Enter the number for order "+ (x + 1) + " : ");
                orders[x].OrderNumber = Convert.ToInt32(Console.ReadLine());
                numberOK  = true;

                //eliminate duplicate order numbers
                for ( y = 0; y < x; ++y)
                {
                    if (orders[x].Equals(orders[y]))
                        numberOK = false;
                                 
                }
                    while (!numberOK )
                    {
                        Console.Write("Re-enter the number for order " + (x + 1) + " : ");
                        orders[x].OrderNumber = Convert.ToInt32(Console.ReadLine());
                        numberOK = true;

                        for ( y = 0; y < x; ++y)
                        {
                            if ((orders[x]).Equals(orders[y]))
                                numberOK = false;

                        }
                    }
                
                Console.Write("Enter the Customer Name " + (x + 1) + " : ");
                orders[x].CustomerName = Console.ReadLine();
                Console.Write("Enter quantity ordered " + (x + 1) + " : ");
                orders[x].QuantityOrdered = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                

            }
            
            //display data using the overriden ToString () method
            Console.WriteLine("The orders are as follows:");
            Console.WriteLine("**************************");
            for (int i = 0; i < orders.Length; ++i)
            {
                Console.WriteLine(orders[i].ToString());
                Console.WriteLine();
            }

            //display total price of orders
            for (x = 0; x < orders.Length; ++x)
            {
                totalOrders += orders[x].TotalPrice;
                
            }
            Console.WriteLine("Total Price of orders are " + totalOrders);

            Console.ReadLine();


        }
        public static void CompareOrders(Order one, Order two)
        {
            if (one.Equals(two))
            {
                Console.WriteLine("The two orders are equal");
                Console.WriteLine("************************");
                Console.WriteLine("Order Number " + one.OrderNumber + " is equal to " + two.OrderNumber);
                Console.WriteLine("Customer Name " + one.CustomerName + " is equal to " + two.CustomerName);
                Console.WriteLine("Quantity Ordered " + one.QuantityOrdered + " is equal to " + two.QuantityOrdered);
            }
            else
                Console.WriteLine("The two oders are not equal");
        }
    }

    public class Order
    {
       public  const double UNIT_PRICE = 19.95;
       private int orderNumber;
       private  string customerName;
       private int quantityOrdered;
       private  double totalPrice;

       public Order(int num, string name, int quantity)
       {
           orderNumber = num;
           customerName = name;
           quantityOrdered = quantity;
       }

       public Order() : this(9, "ZZZ", 0)
        {
            
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

        public override bool Equals(Object e)
        {
            bool equal;
            Order temp = (Order)e;
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

