using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Models;

namespace ContentsLimitInsurance.Infrastructure.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes().ToList();
            LoadCustomMappings(types);

        }
        private void LoadCustomMappings(IEnumerable<Type> types)
        {
            ICustomMapping[] maps = (from t in types
                                     from i in t.GetInterfaces()
                                     where typeof(ICustomMapping).IsAssignableFrom(t) &&
                                           !t.IsAbstract &&
                                           !t.IsInterface
                                     select (ICustomMapping)Activator.CreateInstance(t)).ToArray();

            foreach (ICustomMapping map in maps.Distinct())
            {
                map.CreateMappings(this);
            }

        }
    }
}
