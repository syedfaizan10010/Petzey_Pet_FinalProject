using AutoMapper;
using PetzeyPetDomain.Entities;
using PetzeyPetDTO.ProfileView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyPetNusinessLogic.Mappers
{
    public class AutoMapperPatient: Profile
    {
        public AutoMapperPatient()
        {
            CreateMap<Patient, CardView>();
        }
    }
}
