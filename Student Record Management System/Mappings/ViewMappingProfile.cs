using AutoMapper;
using Student_Record_Management_System.ViewModels.Account;
using Microsoft.Identity.Client;
using SAS_Record_Management_System.Application.Features.Account.DTO;
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
