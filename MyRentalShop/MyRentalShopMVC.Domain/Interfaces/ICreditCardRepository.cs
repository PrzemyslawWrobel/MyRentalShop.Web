using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface ICreditCardRepository
    {
        void DeleteCreditCard(int creditCardId);

        int AddCreditCard(CreditCard creditCard);

        IQueryable<CreditCard> GetAllCreditCard();

        CreditCard GetCreditCardById(int creditCardId);

        ContactDetail UpdateCreditCard(int creditCardId);

       
    }
}
