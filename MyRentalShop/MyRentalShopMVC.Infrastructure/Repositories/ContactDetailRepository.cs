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

        /// <summary>
        /// Dodaje adress, i inne szczeczgóły kontaktowe
        /// </summary>
        /// <param name="contactDetail"></param>
        /// <returns></returns>
        public int AddContactDetail(ContactDetail contactDetail)
        {
            _context.Add(contactDetail);
            _context.SaveChanges();
            return contactDetail.Id;
        }


        /// <summary>
        /// Usuwa adress, i inne szczeczgóły kontaktowe
        /// </summary>
        /// <param name="contactDetailId"></param>
        public void DeleteContactDetail(int contactDetailId)
        {
            var contactDetail = _context.ContactDetails.Find(contactDetailId);
            if (contactDetail != null)
            {
                _context.ContactDetails.Remove(contactDetail);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Pobiera szczegóły o osobie do kotaktu - osoba reprezentująca klienta - firmę, 
        /// bądź klient indywidualny
        /// </summary>
        /// <returns></returns>
        public IQueryable<ContactDetail> GetAllContactDetails()
        {
            var contactDetailsList = _context.ContactDetails;
            return contactDetailsList;
        }
        /// <summary>
        /// Pobiera jeden typ z kontaktów czy jest to nr telefonu, fax ... email
        /// </summary>
        /// <param name="contactDetailTypeId"></param>
        /// <returns></returns>
        public IQueryable<ContactDetail> GetAllContactDetailsTypeID(int contactDetailTypeId)
        {
            var contactDetails = _context.ContactDetails.Where(i => i.Id == contactDetailTypeId);
            return contactDetails;
        }

        /// <summary>
        /// pobiera wszystkie telefony i email
        /// </summary>
        /// <returns></returns>
        public IQueryable<ContactDetailType> GetAllContactDetailTypes()
        {
            var contactDetailTypes = _context.ContactDetailTypes;
            return contactDetailTypes;
        }

        /// <summary>
        /// Pobiera jeden adres wg typu
        /// </summary>
        /// <param name="contactDetailId"></param>
        /// <returns></returns>
        public ContactDetail GetContactDetailById(int contactDetailId)
        {
            var contactDetail = _context.ContactDetails.FirstOrDefault(i => i.Id == contactDetailId);
            return contactDetail;
        }
        //TODO Metoda  UpdateContactDetail do implementacji
        public ContactDetail UpdateContactDetail(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
