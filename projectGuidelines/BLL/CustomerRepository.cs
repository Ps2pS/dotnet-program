using System;
using model;

namespace BLL{
  public class CustomerRepository : ICustomerRepository{
    List<Customer> lscust;

    public CustomerRepository()
    {
      lscust = new List<Customer>();
    }
     void ICustomerRepository.createCustomer(Customer cobj){
      lscust.Add(cobj);
     }

     IEnumerable<Customer> ICustomerRepository.fetchCustomer(){
      return lscust;
     }
  }
}