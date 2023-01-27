using System;
using System.Collections.Generic;
using Day7.List.Models;

namespace Day7.List.Service
{
    public class EmployeeOperation : IEmployeeOperation
    {
        List<Employee> objList = new List<Employee>();
        void IEmployeeOperation.AddEmployee(Employee obj)
        {
            objList.Add(obj);
        }

        List<Employee> IEmployeeOperation.FetchEmployee()
        {
            return objList;
        }
    }
}
