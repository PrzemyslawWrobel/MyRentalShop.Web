using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    /// <summary>
    /// Przechowuje informacje czy to jest nr tel czy nr faksu czy adres email
    /// </summary>
    public class ContactDetailType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
