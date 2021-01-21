using Microsoft.Extensions.DependencyInjection;
using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();

            return services;
        }
    }
}
