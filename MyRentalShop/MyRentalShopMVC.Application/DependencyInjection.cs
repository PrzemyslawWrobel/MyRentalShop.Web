using Microsoft.Extensions.DependencyInjection;
using MyRentalShopMVC.Application.Services;
using MyRentalShopMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using AutoMapper;

namespace MyRentalShopMVC.Application
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Służy do wstrzykiwania zależności, w klasie Startup jest tylko jedna linijka kodu
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
