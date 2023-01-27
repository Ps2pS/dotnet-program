using System;
using Day_5.Models;
using System.Collections;
namespace Day_5.Service
{
    public interface IEmployeeOperations
    {
        void AddEmployee(Employee obj);
        void RemEmployee(Employee Obj1);
        void displayEmployee();
    }
}