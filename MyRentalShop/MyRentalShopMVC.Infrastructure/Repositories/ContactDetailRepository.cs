using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    public class ContactDetailRepository : IContactDetailRepository
    {
        private readonly Context _context;
        public ContactDetailRepository(Context context)
        {
            _context = context;
        }
        public int AddItem(ContactDetail contactDetail)
        {
            _context.Add(contactDetail);
            _context.SaveChanges();
            return contactDetail.Id;
        }

        public void DeleteContactDetail(int contactDetailId)
        {
            var contactDetail = _context.ContactDetails.Find(contactDetailId);
            if (contactDetail != null)
            {
                _context.ContactDetails.Remove(contactDetail);
                _context.SaveChanges();
            }
        }

        public IQueryable<ContactDetail> GetAllContactDetails()
        {
            var contactDetails = _context.ContactDetails;
            return contactDetails;
        }

        public ContactDetail GetContactDetailById(int contactDetailId)
        {
            var contactDetail = _context.ContactDetails.FirstOrDefault(i => i.Id == contactDetailId);
            return contactDetail;
        }

        public ContactDetail UpdateContactDetail(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
