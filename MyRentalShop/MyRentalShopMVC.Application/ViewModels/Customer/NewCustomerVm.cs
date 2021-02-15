using AutoMapper;
using FluentValidation;
using MyRentalShopMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class NewCustomerVm : IMapFrom<MyRentalShopMVC.Domain.Model.Customer>
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

        /// <summary>
        /// Regon firmy wypożyczającej
        /// </summary>
        public string REGON { get; set; }

        /// <summary>
        /// Czy klient jest aktywny
        /// </summary>
        public bool IsActiv { get; set; }

        /// <summary>
        /// Mapuje z wartości wpisane w formularzu do model w backendzie. .ReversMap() - tworzy mapę odwrotną od Customer na NewCustomerVm
        /// </summary>
        /// <param name="profile"></param>
        public void Mapping(Profile profile)
        {
           profile.CreateMap<NewCustomerVm, MyRentalShopMVC.Domain.Model.Customer>().ReverseMap();
        }
    }

    public class NewCustomerValidation : AbstractValidator<NewCustomerVm>
    {
        public NewCustomerValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.NIP).Length(10);
            RuleFor(x => x.REGON).Length(9,14);
            RuleFor(x => x.Name).Length(3,255);
            
        }


    }
}
