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

        public int AddAddress(Address address)
        {
            _context.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }

        public Address GetAddressById(int addressId)
        {
            var address = _context.Addresses.FirstOrDefault(i => i.Id == addressId);
            return address;
        }

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
