// See https://aka.ms/new-console-template for more information
using Day6.Service;
using System;
using System.Collections.Generic;
using Day6.Models;


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

        objoperation.FetchEmployee(); 
    }
}
