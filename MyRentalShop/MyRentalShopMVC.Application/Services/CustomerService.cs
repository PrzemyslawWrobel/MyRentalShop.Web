
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyRentalShopMVC.Application.Interfaces;
using MyRentalShopMVC.Application.ViewModels.Customer;
using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
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
            var newCustomer = _mapper.Map<Customer>(customer);
            var id = _customerRepository.AddCustomer(newCustomer);
            return id;
        }


        /// <summary>
        /// Metoda do pobierania wszystkich użytkowników z bazy, otrzymujemy listę użytkowników
        /// </summary>
        /// <param name="pageSize">Ilość użytkowników na jedna stronę</param>
        /// <param name="pageNo">Numer strony do wyświetlenia </param>
        /// <param name="searchString">Wyszukiwana fraza</param>
        /// <returns></returns>
        public ListCustomerForListVm GetAllCostomerForList(int pageSize, int pageNo, string searchString)
        {
            var customers = _customerRepository.GetAllCustomers().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();

            var customerToShow = customers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();

            var customerList = new ListCustomerForListVm()
            {

                PegeSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Customers = customerToShow,
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
            var customer = _customerRepository.GetCustomerById(customerId);
            var customerVm = _mapper.Map<CustomerDetailsVm>(customer);

            //customerVm.Addresses = new List<AddressForListVm>();
            //customerVm.Emails = new List<ContactDetailListVm>();
            //customerVm.PhoneNumbers = new List<ContactDetailListVm>();

            //foreach (var adresess in customer.Adresses)
            //{
            //    var addressesToList = new AddressForListVm()
            //    {
            //        Id = adresess.Id,

            //    };
            //    customerVm.Addresses.Add(addressesToList);
            //}

            return customerVm;
        }

        public NewCustomerVm GetCustomerForEdit(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            var customerVm = _mapper.Map<NewCustomerVm>(customer);
            return customerVm;
        }
    }
}
