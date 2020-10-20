using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;

        public CustomerRepository(Context context)
        {
            _context = context;
        }
        public int AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAllActiveCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
