using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string Name { get; set; } 
        
        /// <summary>
        /// Data rejestracji użytkownika
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Numer pesel
        /// </summary>
        public int PESEL { get; set; }

        /// <summary>
        /// Wiek klienta indywidualnego, wymagany do wyporzyczenia niektórych aut
        /// </summary>
        public int AgeCustomer { get; set; }

        /// <summary>
        /// Status informujący czy użytkownik może wypożyczać produkty
        /// </summary>
        public int CustomerStatusId { get; set; }

        /// <summary>
        /// Nr Dowodu Osobistego
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// Data ważności dowodu osobistego
        /// </summary>
        public DateTime IDCardExpiryDate { get; set; }

        /// <summary>
        /// Numer Paszportu
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Data ważności paszportu
        /// </summary>
        public DateTime PassportExpiryDate { get; set; }

        /// <summary>
        /// Typ documentu ze zdjęciem
        /// </summary>
        public string OtherTypeDocument { get; set; }

        /// <summary>
        /// Kategoria prawa jazdy
        /// </summary>
        public string DrivingLicenseCategory { get; set; }

        /// <summary>
        /// Do kiedy ważne prawo jazdy
        /// </summary>
        public DateTime DrivingLicenseExpiryDate { get; set; }

        /// <summary>
        /// Numer Paszportu
        /// </summary>
        public string OtherDocumentNumber { get; set; }

        /// <summary>
        /// Data ważności paszportu
        /// </summary>
        public DateTime OtherDocumentExpiryDate { get; set; }

        /// <summary>
        /// Numer karty kredytowej do automatycznego obciążania i blokowania kaucji
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Kod zabezpieczający karty kredytowej CVC CVC2 - MasterCard, CVV CVV2 - Visa
        /// </summary>
        public int CVVCreditCardCode { get; set; }

        /// <summary>
        /// NIP firmy wypożyczającej
        /// </summary>
        public string NIP { get; set; }

        /// <summary>
        /// Regon firmy wypożyczającej
        /// </summary>
        public string REGON { get; set; }


        /// <summary>
        /// Obiekt w którym przechowywana jest informacja na temat osoby do kontaktu, tworzymy relację do tabeli w przechowującej osobę reprezentującą firmę
        /// </summary>
        public CustomerContactInformation CustomerContactInformation { get; set; }

        /// <summary>
        /// Kolekcja z której pobiram informacje o nr telofonów i adresach e-mail
        /// </summary>
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
        /// <summary>
        /// kolekcja adresów, informuje o miejscu zamieszkania lub prowadzenia działalności gospodarczej
        /// </summary>
        public virtual ICollection<Address> Adresses { get; set; }


    }
}
