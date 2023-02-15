using System;
using System.Collections.Generic;
using HashSet.Models;

namespace HashSet.Service
{
   public interface IEO
    {
        void AddEmployee(Employee obj);

        HashSet<Employee> FetchEmployee();
    }
}
