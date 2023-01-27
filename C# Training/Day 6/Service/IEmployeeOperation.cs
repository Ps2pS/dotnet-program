using System;
using Day6.Models;


namespace Day6.Service
{
    public interface IEmployeeOperation
    {
       void AddEmployee(Employee obj);

        void FetchEmployee();
    }
}
