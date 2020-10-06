﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
  
    public class ContactDetailType
    {
        public int Id { get; set; }

        /// <summary>
        /// Przechowuje informacje czy to jest nr tel czy nr faksu czy adres email
        /// </summary>
        public string Name { get; set; }
    }
}
