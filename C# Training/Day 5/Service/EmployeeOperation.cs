using System;
using Day_5.Models;
using System.Collections;
namespace Day_5.Service
{
    public class EmployeeOperations : IEmployeeOperations
    {
        ArrayList objList = new ArrayList();
        void IEmployeeOperations.AddEmployee(Employee obj)
        {
            objList.Add(obj);
        }
        void IEmployeeOperations.displayEmployee()
        {
            foreach (Employee objdata in objList)
            {
                Console.WriteLine(objdata.EmpId + " " + objdata.EmpName);
            }
        }
        void IEmployeeOperations.RemEmployee(Employee Obj1)
        {
            objList.Remove(Obj1);
        }
    }
}