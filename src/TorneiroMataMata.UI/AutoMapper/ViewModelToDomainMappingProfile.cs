using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TorneiroMataMata.Domain.Entities;
using TorneiroMataMata.UI.Models.ViewModels.TimeViewModel;

namespace TorneiroMataMata.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TimeIndexViewModel, Time>();
            CreateMap<GrupoIndexViewModel, Grupo>();
        }
    }
}