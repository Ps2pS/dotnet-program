using System;
using Day7.Enumerable.Models;
using System.Collections.Generic;
using Day7.Enumerable.Service;

namespace Day7.Enumerable.Service
{
    public class EmployeeOperation : IEmployeeOperation
    {
        List<Employee> objList = new List<Employee>();
        void IEmployeeOperation.AddEmployee(Employee obj)
        {
            objList.Add(obj);
        }

        IEnumerable<Employee> IEmployeeOperation.FetchEmployee()
        {
            return objList;
        }
    }
}
