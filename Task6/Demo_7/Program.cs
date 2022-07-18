﻿using System;
namespace Bank
{
    class Amount
    {
        static void Main(string[] args)
        {
            int[] customerID = new int[3];
            int[] accountNumber = new int[3];

            string[] accounType = new string[3];

            DateTime[] dateOpened = new DateTime[3];

            double[] deposit = new double[3];
            double[] balance = new double[3];

            int choice = 0;

            int i = 0;
            bool found = false;

        accept:
            {
                Console.Write("Enter the ID of customer : ");
                customerID[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account number :");
                accountNumber[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account type [Fixed/Saving]: (F/S)");
                accounType[i] = Console.ReadLine();
                Console.Write("Enter the date of opening account [MM/DD/YYYY]");
                dateOpened[i] = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the amount deposited : ");
                deposit[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                if (deposit[i] <= 0)
                {
                    Console.WriteLine("Invalid Data Entry");
                    return;
                }
                else
                {
                    balance[i] = balance[i] + deposit[i];
                }
                i++;
            }
            if (i < customerID.Length)
            {
                goto accept;
            }

            Console.WriteLine("Account Details : \n");
            Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDesponsit($)     Balance($)");
            for (i = 0; i < accountNumber.Length; i++)
            {
                Console.Write("{0}\t{1}  \t", customerID[i], accountNumber[i]);
                Console.Write("{0}\t  {1}\t", accounType[i], dateOpened[i].ToShortDateString());
                Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);
            }
            Console.WriteLine("\n\nAccount Details : \n");
            Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($)   Balance($)");
            DateTime today = DateTime.Today.Date;
            for(i = 0; i < customerID.Length; i++)
            {
                int num = (today.Subtract(dateOpened[i])).Days;
                if(num == 0)
                    continue;
                else
                {
                    Console.Write("{0}\t{1} \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t   {1}\t", accounType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);

                }    
            }
            Console.Write("\nEnter the account number whose details you want to view : ");
            choice = Convert.ToInt32(Console.ReadLine());

            for(i = 0; i < accountNumber.Length; i++)
            {
                if(accountNumber[i] == choice)
                {
                    found = true;

                    Console.WriteLine("Record Found!");
                    Console.WriteLine("ID\tA/c No. \tA/c Type Opening Date\tDesposit($)     Balance($)");
                    Console.Write("{0}\t{1}\t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t  {1}\t", accounType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Account does not exist");
                

        }
    }
}
