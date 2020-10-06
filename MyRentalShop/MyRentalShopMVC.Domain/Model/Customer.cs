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
        /// Wiek klienta indywidualnego, wymagany do wyporzyczenia niektórych aut
        /// </summary>
        public int AgeCustomer { get; set; }

        /// <summary>
        /// Status informujący czy użytkownik może wypożyczać produkty
        /// </summary>
        public int CustomerStatusId { get; set; }

        /// <summary>
        /// Obiekt w którym przechowywana jest informacja na temat osoby do kontaktu, tworzymy relację do tabeli w przechowującej osobę reprezentującą firmę
        /// </summary>
        public CustomerContactInformation CustomerContactInformation { get; set; }

        /// <summary>
        /// Kolekcja z której pobieram informacje o nr telofonów i adresach e-mail
        /// </summary>
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }

        /// <summary>
        /// kolekcja adresów, informuje o miejscu zamieszkania lub prowadzenia działalności gospodarczej
        /// </summary>
        public virtual ICollection<Address> Adresses { get; set; }

        /// <summary>
        /// kolekcja dokumentów, jakimi legitymuje się customer
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }


    }
}
