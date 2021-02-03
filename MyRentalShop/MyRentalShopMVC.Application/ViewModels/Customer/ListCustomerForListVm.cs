using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class ListCustomerForListVm
    {
        /// <summary>
        /// Lista użytkowników do wyświetlenia
        /// </summary>
        public List<CustomerForListVm> Customers { get; set; }
        
        /// <summary>
        /// Przechowuju info o nr strony która jest wyswietlana
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Przechowuje info o ilości wierszy na stronie
        /// </summary>
        public int PegeSize { get; set; }

        /// <summary>
        /// Przechowuje bierzące wyszukiwanie
        /// </summary>
        public string SearchString { get; set; }

        public int Count { get; set; }

    }
}
