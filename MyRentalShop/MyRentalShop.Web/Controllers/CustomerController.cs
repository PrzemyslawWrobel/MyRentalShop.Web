using Microsoft.AspNetCore.Mvc;
using MyRentalShopMVC.Application.Interfaces;
using MyRentalShopMVC.Application.ViewModels.Customer;
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var model = _customerService.GetAllCostomerForList(4, 1, "");
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }

            if(searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _customerService.GetAllCostomerForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }


        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View(new NewCustomerVm());
        }

        [HttpPost]
        public IActionResult AddCustomer(NewCustomerVm model)
        {
            var id = _customerService.AddCustomer(model);
            return RedirectToAction("Index"); //View();
        }

        /// <summary>
        /// Metoda pokazuje jednego wybranego użytkownika 
        /// </summary>
        /// <param name="Id"> Mieniony z customerId na Id ponieważ rooting nie działał </param>
        /// <returns></returns>

        //[Route("ViewCustomer/customerId")]
        [HttpGet]
        public IActionResult ViewCustomer(int Id)
        {
            var customerModel = _customerService.GetCustomerDetails(Id);
            return View(customerModel);
        }

        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            var customer = _customerService.GetCustomerForEdit(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult EditCustomer(NewCustomerVm model)
        {
            _customerService.UpdateCustomer(model);
            return RedirectToAction("Index"); //View();
        }



    }
}
