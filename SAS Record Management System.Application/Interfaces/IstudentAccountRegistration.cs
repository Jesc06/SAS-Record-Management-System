using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Application.DTOs;

namespace SAS_Record_Management_System.Application.Interfaces
{
    public interface IstudentAccountRegistration
    {   
        Task AddAsync(StudentAccountRegistrationDTO dto);
    }
}
