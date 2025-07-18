﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS_Record_Management_System.Domain.Entities;
using SAS_Record_Management_System.Application.Features.Account.DTO;
using SAS_Record_Management_System.Application.Features.Account.Interfaces;

namespace SAS_Record_Management_System.Application.Features.Account.Services
{
    public class StudentAccountRegistrationService
    {
        private readonly IstudentAccountRegistration _studentAccountRegistration;
        public StudentAccountRegistrationService(IstudentAccountRegistration studentAccountRegistration)
        {
            _studentAccountRegistration = studentAccountRegistration;
        }


        public async Task<bool> RegisterAccountAsync(StudentAccountRegistrationDTO model)
        {
            await _studentAccountRegistration.AddAsync(model);
            return true;
        }



    }
}
