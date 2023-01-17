using AutoMapper;
using PetzeyPetDomain.Entities;
using PetzeyPetDTO.ProfileView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyPetBusinessLogic.AutoMapper
{
    public class AutoMapperPatient:Profile
    {
        //public AutoMapperPatient()
        //{ 
        ////    CreateMap<Patient, CardView>()
        ////    .ForMember(dest => dest.FullName,
        ////    c=> c.MapFrom (src=> $"{src.firstName} { src.lastName}"));

        //    CreateMap<Patient, ListView>().ForMember
        //        (dest => dest.FullName, c => c.MapFrom(src => $"{src.OwnerFirstName} {src.OwnerLastName}"));
        //    CreateMap<>
        //}
        public AutoMapperPatient()
        {
            CreateMap<Patient, ListView>().ForMember
                (dest => dest.FullName, c => c.MapFrom(src => $"{src.OwnerFirstName} {src.OwnerLastName}"));
        }
    }
}
