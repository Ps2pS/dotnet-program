using System;
using Day7.Enumerable.Models;


namespace Day7.Enumerable.Service
{
    public interface IEmployeeOperation
    {
        void AddEmployee(Employee obj);

        IEnumerable<Employee> FetchEmployee();
    }
}
