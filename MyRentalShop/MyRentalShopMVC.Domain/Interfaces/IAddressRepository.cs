using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface IAddressRepository
    {
        void DeleteAddress(int addressId);
        int AddAddress(Address address);
        IQueryable<Address> GetAllAddresses();
        Address GetAddressById(int addressId);

        Item UpdateAddress(int addressId);
    }
}
