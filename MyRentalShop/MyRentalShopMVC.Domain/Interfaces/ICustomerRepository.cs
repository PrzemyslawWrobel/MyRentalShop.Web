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
        IQueryable<Customer> GetAllCustomers();
        IQueryable<Customer> GetAllActiveCustomers(bool isActiv);
        void DeleteCustomer(int customerId);
        void UpdateCustomer(Customer customer);

        int AddCustomerContactInf(CustomerContactInformation customerContactInformation);
        void DeleteCustomerContactInf(int customerContactInformationId);
        CustomerContactInformation UpdataCustomerContactInf(int customerContactInformationId);

    }
}
