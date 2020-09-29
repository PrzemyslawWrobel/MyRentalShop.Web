using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Imie klienta
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Drugie Imię klienta, nie jest wymagane
        /// </summary>
        public string SecondName { get; set; }
        
        /// <summary>
        /// Nazwisko klienta
        /// </summary>
        public string LastName { get; set; }
        
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
        /// Nazwa ulicy
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Numer Bloku, Domu
        /// </summary>
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Numer mieszkania
        /// </summary>
        public int FlatNumber { get; set; }

        /// <summary>
        /// Kod pocztowy
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Nazwa miasta, Wsi
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// Nazwa Kraju
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// Główny nr telefonu
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Dodatkowy nr telefonu
        /// </summary>
        public string PhoneNumberSecond { get; set; }

        /// <summary>
        /// Adres poczty e-mail do kontaktu z klientem i wysyłania powiadomień
        /// </summary>
        public string EmailAdress { get; set; }
    }
}
