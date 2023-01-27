﻿// See https://aka.ms/new-console-template for more information
using Day7.List.Service;
using System;
using System.Collections.Generic;
using Day7.List.Models;

public class MyData
{
    public static void Main()
    {
        IEmployeeOperation objoperation = new EmployeeOperation();
        Employee objemployee = new Employee();
        objemployee.EmpId = 101;
        objemployee.EmpName = "Sonu";

        objoperation.AddEmployee(objemployee);

        Employee objemployee1 = new Employee();
        objemployee1.EmpId = 102;
        objemployee1.EmpName = "Tannu";

        objoperation.AddEmployee(objemployee1);

        List<Employee> ret = objoperation.FetchEmployee();  //linq query

        foreach (Employee data in ret)
        {
            Console.WriteLine(data.EmpId + " " + data.EmpName);
        }
    }
}
