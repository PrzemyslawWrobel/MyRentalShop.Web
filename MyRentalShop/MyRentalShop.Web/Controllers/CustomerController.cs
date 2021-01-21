using Microsoft.AspNetCore.Mvc;
using MyRentalShopMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRentalShop.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var model = _customerService.GetAllCostomerForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddCustomer(CustomerModel model)
        //{
        //    var id = _customerService.AddCustomer(model);
        //    return View();
        //}

        public IActionResult ViewCustomer(int customerId)
        {
            var customerModel = _customerService.GetCustomerDetails(customerId);
            return View(customerModel);
        }
    }
}
