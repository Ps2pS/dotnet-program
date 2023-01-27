using System;
using Day_5.Models;
using Day_5.Service;
namespace Day_5
{
    public class Program
    {
        static void Main()
        {
            IEmployeeOperations iemp = new EmployeeOperations();
            Employee Obj = new Employee();
            Obj.EmpId = 105;
            Obj.EmpName = "Deepak";
            iemp.AddEmployee(Obj);
            Employee Obj1 = new Employee();
            Obj1.EmpId = 110;
            Obj1.EmpName = "Deepali";
            iemp.AddEmployee(Obj1);
            iemp.RemEmployee(Obj1);
            Employee Obj2 = new Employee();
            Obj2.EmpId = 111;
            Obj2.EmpName = "Rishi";
            iemp.AddEmployee(Obj2);
            iemp.displayEmployee();

            Console.WriteLine("Enter Employee name:");
            string updatename = Console.ReadLine();
            Obj.EmpName = updatename;
            iemp.AddEmployee(Obj);
            iemp.displayEmployee();

            //Employee[] empArray = new Employee[]
            //{
            //    Obj,Obj1,Obj2
            //};
            List<Employee> EmpList = new List<Employee>() { Obj, Obj1, Obj2 };
            var Employee = EmpList.FirstOrDefault(o => o.EmpName == "Deepak");
            if (Employee != null)
            {
                Console.WriteLine("Found a user with name");
                Console.WriteLine(Employee.EmpName);
            }
            else
            {
                Console.WriteLine("No name found");
            }
        }
    }
}