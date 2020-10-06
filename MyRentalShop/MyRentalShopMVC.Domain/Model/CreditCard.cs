using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class CreditCard
    {
        public int Id { get; set; }

        /// <summary>
        /// Przechowuje nazwę banku wydajacego kartę
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Numer karty kredytowej do automatycznego obciążania i blokowania kaucji
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Kod zabezpieczający karty kredytowej CVC CVC2 - MasterCard, CVV CVV2 - Visa
        /// </summary>
        public int CVVCreditCardCode { get; set; }

        /// <summary>
        /// Data ważności karty
        /// </summary>
        public int ValidThru { get; set; }

        /// <summary>
        /// Nazwa użytkownika karty kredytowej
        /// </summary>
        public string CreditCardUserName { get; set; }

        ///właściwości wskazujące na tabele klienta 
        /// <summary>
        /// Klucz obcy wskazujący na tabelę Customer - kolumnę z ID
        /// </summary>
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
