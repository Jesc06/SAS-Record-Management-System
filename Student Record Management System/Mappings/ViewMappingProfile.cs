using AutoMapper;
using Student_Record_Management_System.ViewModels.Account;
using SAS_Record_Management_System.Application.DTOs;
using Microsoft.Identity.Client;
namespace Student_Record_Management_System.Mappings
{
    public class ViewMappingProfile : Profile
    {
        public ViewMappingProfile()
        {
            CreateMap<RegisterViewModel, StudentAccountRegistrationDTO>();     
        }
    }
  
}
