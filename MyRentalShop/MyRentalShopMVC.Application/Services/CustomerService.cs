
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyRentalShopMVC.Application.Interfaces;
using MyRentalShopMVC.Application.ViewModels.Customer;
using MyRentalShopMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metoda do pobierania wszystkich użytkowników z bazy, otrzymujemy listę użytkowników
        /// </summary>
        /// <returns> </returns>
        public ListCustomerForListVm GetAllCostomerForList()
        {
            var customers = _customerRepository.GetAllCustomers()
                .ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();
            var customerList = new ListCustomerForListVm()
            {
                Customers = customers,
                Count = customers.Count
            };
            return customerList;  

            //Po dodaniu AutoMappera kod poniżej już nie jest potrzebny

            //ListCustomerForListVm result = new ListCustomerForListVm();
            //result.Customers = new List<CustomerForListVm>();
            //foreach (var customer in customers)
            //{
            //    var customerVm = new CustomerForListVm()
            //    {
            //        Id = customer.Id,
            //        Name = customer.Name,
            //        NIP = customer.NIP,

            //    };
            //    result.Customers.Add(customerVm);

            //}
            //result.Count = result.Customers.Count;
            //return result;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
