// See https://aka.ms/new-console-template for more information
using Day7.Enumerable.Service;
using System;
using System.Collections.Generic;
using Day7.Enumerable.Models;


public class MyData
{
    public static void Main()
    {
        IEmployeeOperation objoperation = new EmployeeOperation();
        Employee objemployee = new Employee();
        objemployee.EmpId = 101;
        objemployee.EmpName = "Nimi";

        objoperation.AddEmployee(objemployee);

        Employee objEmployee1 = new Employee();
        objEmployee1.EmpId = 102;
        objEmployee1.EmpName = "Nimisha";

        objoperation.AddEmployee(objEmployee1);

        IEnumerable<Employee> ret = objoperation.FetchEmployee();
        foreach(Employee data in ret)
        {
            Console.WriteLine(data.EmpId + " " + data.EmpName);
        }
    }
}
