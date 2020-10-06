using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class CreditCard
    {
        public int Id { get; set; }

        /// <summary>
        /// Przechowuje nazwę karty
        /// </summary>
        public string DocumentDetailInformation { get; set; }
    }
}
