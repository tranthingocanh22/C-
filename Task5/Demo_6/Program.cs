using System;

namespace Bank
{
    class Employee
    {
        static void Main(string[] args)
        {
            int employeeID;

            string employeeName;
            string designation = "";

            DateTime birthDate;

            char gender;

            byte yearsServed;

            double bouns = 0, salary = 0, taxtAmount, netSalary = 0;

            Console.Write("Enter the ID of employee : ");
            employeeID = Convert.ToInt32(Console.ReadLine());
            if(employeeID > 0)
            {
                Console.Write("Enter the name of employee: ");
                employeeName = Console.ReadLine();
                if(employeeName != "" && employeeName.Length < 40)
                {
                    Console.Write("Enter date of birh [MM/DD/YYYY]: ");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    int age = (DateTime.Today.Subtract(birthDate)).Days / 365;
                    if (age >= 18)
                    {
                        Console.Write("Enter gender [M/F]: ");
                        gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("Select designation(choose the number ): ");
                        Console.WriteLine("1.Manager \n2. System Analyst \n3. Developer \n4. Accountant");
                        Console.Write("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the tenure in years : ");
                        yearsServed = Convert.ToByte(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                designation = "Manager";
                                salary = 21346;
                                break;
                            case 2:
                                designation = "System Analyst";
                                salary = 16729;
                                break;
                            case 3:
                                designation = "Developer";
                                salary = 14525;
                                break;
                            case 4:
                                designation = "Accountant";
                                salary = 13215;
                                break;

                        }
                        if (yearsServed >= 3)
                        {
                            if (salary > 2000)
                            {
                                bouns = salary * 0.09;
                            }
                            else if (salary > 14000 && salary <= 20000) {
                                bouns = salary * 0.05;
                            }
                            else
                            {
                                bouns = salary * 0.02;
                            }
                        }
                        taxtAmount = salary * 33 / 100;
                        netSalary = salary - taxtAmount;

                        Console.WriteLine("Employee ID : " + employeeID);
                        Console.WriteLine("Employee Name : " + employeeName);
                        Console.WriteLine("Date of Birth : " + birthDate);
                        if (gender == 'M')
                            Console.WriteLine("Gender : Male");
                        else
                            Console.WriteLine("Gender : Female");
                        Console.WriteLine("Designation  : " + designation);
                        Console.WriteLine("Tenure : ", yearsServed);
                        Console.WriteLine("Salary : {0} $ ", salary);
                        Console.WriteLine("Tax Amount : {0} $ ", taxtAmount);
                        Console.WriteLine("Net Salary :  {0:F2} $ is rounded off to : {1} $", netSalary, (int)netSalary);
                        Console.WriteLine("Bouns : {0} $ ", bouns);

                    }
                    else
                    {
                        Console.WriteLine("Invalid entry forr date of birth");
                    }
            }
                else
                {
                    Console.WriteLine("Invalid entry for employee name");
                }
        }
            else
            {
                Console.WriteLine("Invalid entry for employee ID");
            }
    }
}