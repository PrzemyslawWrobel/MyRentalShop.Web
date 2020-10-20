using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        int AddCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        IQueryable<Customer> GetAllActiveCustomers();
        void DeleteCustomer(int customerId);
        Customer UpdateCustomer(int customerId);

        



    }
}
