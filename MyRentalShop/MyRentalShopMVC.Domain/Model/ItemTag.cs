using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    /// <summary>
    /// Klasa służy do powiązania tagów z itemami relacjami wiele do wielu
    /// </summary>
    public class ItemTag
    {
        /// <summary>
        /// Klucz obcy
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Obiekt produktu
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// Klucz obcy
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// Obiekt do przetrzymywania tagu
        /// </summary>
        public Tag Tag { get; set; }
    }
}
