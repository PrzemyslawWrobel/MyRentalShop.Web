using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly Context _context;

        public AddressRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Dodaje adres klienta 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public int AddAddress(Address address)
        {
            _context.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        /// <summary>
        /// Usuwa adres klienta
        /// </summary>
        /// <param name="addressId"></param>
        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Pobiera adres po typie(domowy, siedziba firmy)
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address GetAddressByTypeId(int addressTypeId)
        {
            var address = _context.Addresses.FirstOrDefault(i => i.Id == addressTypeId);
            return address;
        }

        /// <summary>
        /// Pobiera wszystkie adresy 
        /// </summary>
        /// <returns></returns>
        public IQueryable<Address> GetAllAddresses()
        {
            var address = _context.Addresses;
            return address;
        }

        ///TODO metoda update do implementacji
        public Item UpdateAddress(int addressId)
        {
            throw new NotImplementedException();
        }
    }
}
