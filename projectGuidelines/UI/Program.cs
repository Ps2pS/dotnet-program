using BLL;
using model;
using System.Collections.Generic;

class Controller{
  public static void Main()
  {
    Customer obj = new Customer();
    obj.CustId = 101;
    obj.CustName = "Pragya";

    ICustomerRepository cr = new CustomerRepository();

    cr.createCustomer(obj);

    IEnumerable<Customer> ic = cr.fetchCustomer();

    foreach (var s in ic){
      System.Console.WriteLine(s.CustId);
      System.Console.WriteLine(s.CustName);
    }
  }
}