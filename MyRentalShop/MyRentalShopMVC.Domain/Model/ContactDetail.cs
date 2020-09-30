using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class ContactDetail
    {
        public int Id { get; set; }

        /// <summary>
        /// Przechowuje telefony, emil
        /// </summary>
        public string ContactDetailInformation { get; set; }

        /// <summary>
        /// klucz obcy 
        /// </summary>
        public int ContactDetailTypeId { get; set; }

        /// <summary>
        /// przechowuje w obiekcie informacje czy to jest telefon czy adres email
        /// </summary>
        public ContactDetailType ContactDetailType { get; set; }

        ///właściwości wskazujące na tabele klienta 
        /// <summary>
        /// Klucz obcy wskazujący na tabelę Customer - kolumnę z ID
        /// </summary>
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
