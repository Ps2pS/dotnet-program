using System;
using System.Collections.Generic;
using HashSet.Models;

namespace HashSet.Service
{
 public class EO:IEO
    {
        HashSet<Employee> objList = new HashSet<Employee>();

        void IEO.AddEmployee(Employee obj)
        {
            objList.Add(obj);
        }

        HashSet<Employee> IEO.FetchEmployee()
        {
            return objList;
        }
    }
}
