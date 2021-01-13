using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class CustomerForListVm
    {
        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// NIP firmy wypożyczającej
        /// </summary>
        public string NIP { get; set; }

        /// <summary>
        /// Regon firmy wypożyczającej
        /// </summary>
        public string REGON { get; set; }

        public string FirstLineOfContactInformation { get; set; }

        /// <summary>
        /// Lista adresów firmy lub użytkownika
        /// </summary>
        public List<AddressForListVm> Adresses { get; set; }

        /// <summary>
        /// Lista adresów email 
        /// </summary>
        public List<ContactDetailListVm> Emails { get; set; }

        /// <summary>
        /// Lista telefonów 
        /// </summary>
        public List<ContactDetailListVm> PhoneNumbers { get; set; }

    }
}
