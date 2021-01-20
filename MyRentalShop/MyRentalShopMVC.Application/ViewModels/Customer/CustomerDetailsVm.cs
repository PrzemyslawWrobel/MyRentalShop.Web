using AutoMapper;
using MyRentalShopMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Application.ViewModels.Customer
{
    public class CustomerDetailsVm : IMapFrom<MyRentalShopMVC.Domain.Model.Customer>
    {
        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string FullName { get; set; }

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


       // public string FirstLineOfContactInformation { get; set; }

        /// <summary>
        /// Lista adresów firmy lub użytkownika
        /// </summary>
        public List<AddressForListVm> Adresses { get; set; }

        /// <summary>
        /// Lista adresów email 
        /// </summary>
        public List<ContactDetailListVm> Emails { get; set; }

        /// <summary>
        /// Lista telefonów 
        /// </summary>
        public List<ContactDetailListVm> PhoneNumbers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MyRentalShopMVC.Domain.Model.Customer, CustomerDetailsVm>()
                .ForMember(d => d.FullName, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.Adresses, opt => opt.Ignore())
                .ForMember(d => d.Emails, opt => opt.Ignore())
                .ForMember(d => d.PhoneNumbers, opt => opt.Ignore());


        }
    }
}