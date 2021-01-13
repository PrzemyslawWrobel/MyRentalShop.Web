using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRentalShop.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var model = customerService.GetAllCostomerForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerModel model)
        {
            var id = customerService.AddCustomer(model);
            return View();
        }

        public IActionResult ViewCustomer(int customerId)
        {
            var customerModel = customerService.GetCustomerById(customerId);
            return View(customerModel);
        }
    }
}
