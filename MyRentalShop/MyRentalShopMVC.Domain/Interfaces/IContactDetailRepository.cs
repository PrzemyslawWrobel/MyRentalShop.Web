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

        IQueryable<ContactDetail> GetAllContactDetailsTypeID(int contactDetailTypeId);

        ContactDetail GetContactDetailById(int contactDetailId);

        ContactDetail UpdateContactDetail(int contactDetailId);

        IQueryable<ContactDetailType> GetAllContactDetailTypes();
    }
}
