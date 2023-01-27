using System;
using Day6.Models;
using System.Collections.Generic;

namespace Day6.Service
{
    public class EmployeeOperation : IEmployeeOperation
    {
        List<Employee> objList = new List<Employee>();
        void IEmployeeOperation.AddEmployee(Employee obj)
        {
            objList.Add(obj);
        }

        void IEmployeeOperation.FetchEmployee()
        {
            foreach(var data in objList)
            {
                Console.WriteLine(data.EmpId+" "+data.EmpName);
            }
        }
    }
}
