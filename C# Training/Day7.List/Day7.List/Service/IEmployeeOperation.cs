using System;
using Day7.List.Models;

namespace Day7.List.Service
{
    public interface IEmployeeOperation
    {
        void AddEmployee(Employee obj);

        List<Employee> FetchEmployee();
    }
}
