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
            _context.Customers.Add(customer);
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
        public IQueryable<Customer> GetAllCustomers()
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

        /// <summary>
        /// Zwraca szczegóły wybranego użytkownika
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            return customer;
        }

        //TODO Metoda UpdateCustomer do implementacji
        public void UpdateCustomer(Customer customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).Property("Name").IsModified = true;
            _context.Entry(customer).Property("NIP").IsModified = true;
            _context.Entry(customer).Property("REGON").IsModified = true;
            _context.Entry(customer).Property("IsActiv").IsModified = true;
            _context.SaveChanges();
        }

        /// <summary>
        /// Dodaje dane osoby reprezentującej klienta
        /// </summary>
        /// <param name="customerContactInformation"></param>
        /// <returns></returns>
        public int AddCustomerContactInf(CustomerContactInformation customerContactInformation)
        {
            _context.Add(customerContactInformation);
            _context.SaveChanges();
            return customerContactInformation.Id;
        }

        public void DeleteCustomerContactInf(int customerContactInformationId)
        {
            var contactInfForDelete = _context.Customers.Find(customerContactInformationId);
            if (contactInfForDelete != null)
            {
                _context.Customers.Remove(contactInfForDelete);
                _context.SaveChanges();
            }
        }


        //TODO Metoda UpdataCustomerContactInf do implementacji
        public CustomerContactInformation UpdataCustomerContactInf(int customerContactInformationId)
        {
            throw new NotImplementedException();
        }
    }
}
