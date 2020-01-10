using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TorneiroMataMata.UI.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void ReggisterMapping()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new DomainToViewModelMappingProfile());
                x.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}