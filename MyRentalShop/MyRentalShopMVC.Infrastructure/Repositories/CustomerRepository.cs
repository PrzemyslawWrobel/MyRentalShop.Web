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
        /// <summary>
        /// Dodanie nowego klienta
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public int AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

         /// <summary>
         /// Usunięcie klienta z bazy klientów
         /// </summary>
         /// <param name="customerId"></param>
        public void DeleteCustomer(int customerId)
        {
            var customerForDelete = _context.Customers.Find(customerId);
            if (customerForDelete != null)
            {
                _context.Customers.Remove(customerForDelete);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Zwraca listę wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public IQueryable<Customer> GetAllActiveCustomers()
        {
            var activeCustomers = _context.Customers;
            return activeCustomers;
        }

        /// <summary>
        /// Zwraca listę aktywnych użytkowników
        /// </summary>
        /// <param name="isActiv">true</param>
        /// <returns></returns>
        public IQueryable<Customer> GetAllActiveCustomers(bool isActiv)
        {
            var activeCustomers = _context.Customers.Where(i => i.IsActiv == isActiv);
            return activeCustomers;
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
