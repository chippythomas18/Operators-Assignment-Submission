using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the first Employee object
            Employee employee1 = new Employee();

            //Assign values to the first Employee
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            //Create the second Employee object
            Employee employee2 = new Employee();

            //Assign values to the second Employee
            employee2.Id = 1;
            employee2.FirstName = "David";
            employee2.LastName = "Brown";

            //Compare the Employee objects using the == operator
            Console.WriteLine("Are employees equal? " + (employee1 == employee2));

            //Compare the Employee objects using the != operator
            Console.WriteLine("Are employees different? " + (employee1 != employee2));

            //Keep the console window open
            Console.ReadLine();
        }
    }
}
