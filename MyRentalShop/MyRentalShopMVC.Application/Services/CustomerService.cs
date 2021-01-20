
using MyRentalShopMVC.Application.Interfaces;
using MyRentalShopMVC.Application.ViewModels.Customer;
using MyRentalShopMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCostomerForList()
        {
            var customers = _customerRepository.GetAllCustomers();
            ListCustomerForListVm result = new ListCustomerForListVm();
            result.Customers = new List<CustomerForListVm>();
            foreach (var customer in customers)
            {
                var customerVm = new CustomerForListVm()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    NIP = customer.NIP,

                };
                result.Customers.Add(customerVm);

            }
            result.Count = result.Customers.Count;
            return result;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
