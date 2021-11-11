﻿using AutoMapper;
using Data_Access_Layer.Model;
using KinopoiskAPI.Dto;
using KinopoiskAPI.Dto.CreditCard;

namespace KinopoiskAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieInfoDto>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<User, UserInfoDto>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<CreditCard, CreditCardInfoDto>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}