using APARTMENTS.Dtos;
using APARTMENTS.Extensions;
using APARTMENTS.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Helpers
{ 
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles() {
            CreateMap<User, RegisterDTO>();
            CreateMap<RegisterDTO,User > ();
            //Kalkuliranje Datuma rodjenja za korisnika
            CreateMap<User, MemberDto>().ForMember(dest => dest.Age, opt=> opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UsersApartmentsDto>()
                .ForMember(dto => dto.apartment, c => c.MapFrom(c => c.contracts.Select(cs => cs.Apartment)));


            CreateMap<Card, CardDto>();
            CreateMap<CardDto, Card>();
            CreateMap<MemberDto, User>();
        }
    }
}
