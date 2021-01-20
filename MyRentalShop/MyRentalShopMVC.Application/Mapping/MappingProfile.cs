using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyRentalShopMVC.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                 .Where(t => t.GetInterfaces().Any(i =>
                 i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                 .ToList();

            foreach (var type in types)
            {
                var instansce = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instansce, new object[] { this });
            }
        }
    }
}
