using MyRentalShopMVC.Application.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCostomerForList(int pageSize, int pageNo, string searchString);
        int AddCustomer(NewCustomerVm customer);
        CustomerDetailsVm GetCustomerDetails(int customerId);

        //TODO Zmienić NewCustomerVm na pełny model do edycji
        NewCustomerVm GetCustomerForEdit(int id);
        void UpdateCustomer(NewCustomerVm model);
    }
}
