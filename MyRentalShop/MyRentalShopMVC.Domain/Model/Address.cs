using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public  class Address
    {
        public int Id { get; set; }

        /// <summary>
        /// Jaki adres domowy, do korespondencji, zamieszkanaia, wykonywania działalności
        /// </summary>
        public string AddressType { get; set; }

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
        /// klucz obcy, Relacja do klienta
        /// </summary>
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
