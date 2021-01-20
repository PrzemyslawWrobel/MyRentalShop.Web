using AutoMapper;
using MyRentalShopMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class CustomerForListVm : IMapFrom<MyRentalShopMVC.Domain.Model.Customer>
    {
        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// NIP firmy wypożyczającej
        /// </summary>
        public string NIP { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyRentalShopMVC.Domain.Model.Customer, CustomerForListVm>();

            //jeżeli mapowane właściwości mają takie same nazwy nie trzeba dokładnie wskazywać z jakiej właściwości mapujemy na jaką właściwość
                    //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                    //.ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                    //.ForMember(d => d.NIP, opt => opt.MapFrom(s => s.NIP));

        }

    }
}
