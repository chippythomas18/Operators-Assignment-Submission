using System;

namespace OperatorOverloadingAssignment
{
    //Create an Employee class
    public class Employee
    {
        //Create properties for Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        //Overload the != operator as a pair with the == operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        //Override Equals to compare Employee objects by Id
        public override bool Equals(object obj)
        {
            Employee employee = obj as Employee;
            return employee != null && Id == employee.Id;
        }

        //Override GetHashCode to use the Id property
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
