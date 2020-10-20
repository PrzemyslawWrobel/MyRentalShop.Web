using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface IContactDetailRepository
    {
        void DeleteContactDetail(int contactDetailId);

        int AddItem(ContactDetail contactDetail);

        IQueryable<ContactDetail> GetAllContactDetails();


        ContactDetail GetContactDetailById(int itemId);

        ContactDetail UpdateContactDetail(int itemId);
    }
}
