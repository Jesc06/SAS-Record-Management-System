using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Domain.Entities.Account;

namespace SAS_Record_Management_System.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentAccountRegistrationDTO, StudentAccountRegistration>();
            CreateMap<StudentAccountRegistration, StudentAccountRegistrationDTO>();
        }
    }
   
}
