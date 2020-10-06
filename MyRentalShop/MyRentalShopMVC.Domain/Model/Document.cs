using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class Document
    {
        public int Id { get; set; }

        /// <summary>
        /// Przechowuje nazwę dokumentu
        /// </summary>
        public string DocumentDetailInformation { get; set; }

        /// <summary>
        /// Narodowość
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Numer Dowodu osobistego
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Data ważności dokumentu
        /// </summary>
        public DateTime DocumentExpiryDate { get; set; }

        /// <summary>
        /// Data urodzenia
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Numer pesel
        /// </summary>
        public int PESEL { get; set; }

        /// <summary>
        /// Kategoria prawa jazdy
        /// </summary>
        public string DrivingLicenseCategory { get; set; }

        ///właściwości wskazujące na tabele klienta 
        /// <summary>
        /// Klucz obcy wskazujący na tabelę Customer - kolumnę z ID
        /// </summary>
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
