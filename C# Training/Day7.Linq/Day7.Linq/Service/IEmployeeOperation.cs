using System;
using Day7.Linq.Models;

namespace Day7.Linq.Service
{
    public interface IEmployeeOperation
    {
        void AddEmployee(Employee obj);

        List<Employee> FetchEmployee();
    }
}
