using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly Context _context;
        public CreditCardRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Dodawanie nowej karty płatniczej dla użytkownika
        /// </summary>
        /// <param name="creditCard"></param>
        /// <returns></returns>
        public int AddCreditCard(CreditCard creditCard)
        {
            _context.Add(creditCard);
            _context.SaveChanges();
            return creditCard.Id;
        }

        /// <summary>
        /// Usunięcie karty płatniczej dla użytkownika
        /// </summary>
        /// <param name="creditCardId"></param>
        public void DeleteCreditCard(int creditCardId)
        {
            var creditCard = _context.CreditCards.Find(creditCardId);
            if (creditCard !=null)
            {
                _context.CreditCards.Remove(creditCard);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Pobranie listy kart płatniczych użytkownika
        /// </summary>
        /// <returns></returns>
        public IQueryable<CreditCard> GetAllCreditCard()
        {
            var creditCardList = _context.CreditCards;
            return creditCardList;
        }

        /// <summary>
        /// Pobranie jednej karty po Id do wyświetlenia szczegółów karty
        /// </summary>
        /// <param name="creditCardId"></param>
        /// <returns></returns>
        public CreditCard GetCreditCardById(int creditCardId)
        {
            var creditCard = _context.CreditCards.FirstOrDefault(i => i.Id == creditCardId);
            return creditCard;
        }

        //TODO  Metoda UpdateCreditCard do implementacji 
        public ContactDetail UpdateCreditCard(int creditCardId)
        {
            throw new NotImplementedException();
        }
    }
}
