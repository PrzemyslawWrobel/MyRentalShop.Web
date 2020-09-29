using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class CustomerContactInformation
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
        /// Pozycja jaką zajmuje użytkownik w firmie
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Referencja do użytkownika
        /// </summary>
        public int CustomerRef { get; set; }

        /// <summary>
        /// Właściwość przechowuje obiekt użytkownika
        /// </summary>
        public Customer Customer { get; set; }
    }
}
