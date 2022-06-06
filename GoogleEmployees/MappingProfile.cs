﻿using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace GoogleEmployees
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //CreateMap<Company, CompanyDto>().ForMember(c => c.FullAddress,opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            CreateMap<Company, CompanyDto>().ForCtorParam("FullAddress",opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        }
    }
}