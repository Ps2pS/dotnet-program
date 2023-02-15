using System;
using model;

namespace BLL
{
    public interface ICustomerRepository
    {
        void createCustomer(Customer cobj);

        IEnumerable<Customer> fetchCustomer();
    }  
}