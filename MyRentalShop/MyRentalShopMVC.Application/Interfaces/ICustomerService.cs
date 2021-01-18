using MyRentalShopMVC.Application.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCostomerForList();
        int AddCustomer(NewCustomerVm customer);
        CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
