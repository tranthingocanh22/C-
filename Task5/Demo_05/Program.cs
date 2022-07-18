using System;
namespace Company
{
    class Product
    {
        static void Main(string[] args)
        {
            Object objProductID;
            Object objProductName;
            Object objPrice;
            Object objQuantity;

            Console.Write("Enter the id of product : ");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of product : ");
            objProductName = Console.ReadLine();

            Console.Write("Enter price : ");
            objPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity : ");
            objQuantity = Convert.ToInt32(Console.ReadLine());

            int ProductID = (int)objProductID;
            string ProductName = (string)objProductName;
            double Price = (double)objPrice;
            int Quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * Price;

            Console.WriteLine("\nProduct Details: ");
            Console.WriteLine("\nProduct ID: "+ objProductID);
            Console.WriteLine("\nProduct Name: "+ objProductName);
            Console.WriteLine("\nPrice: $ "+ objPrice);
            Console.WriteLine("\nQuantity: "+objQuantity);
            Console.WriteLine("\nAmt Payable {0:F2}: ",amtPayable);
        }
    }
}