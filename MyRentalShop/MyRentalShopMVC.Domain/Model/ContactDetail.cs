using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string ContactDetailInformation { get; set; }
        public int ContactDetailTypeId { get; set; }
        public ContactDetailType ContactDetailType { get; set; }

        ///właściwości wskazujące na tabele klienta 
        /// <summary>
        /// Klucz obcy wskazujący na tabelę Customer - kolumnę z ID
        /// </summary>
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
