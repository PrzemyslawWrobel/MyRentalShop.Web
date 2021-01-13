using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class ListCustomerForListVm
    {
        public List<CustomerForListVm> Customers { get; set; }
        public int Count { get; set; }

    }
}
