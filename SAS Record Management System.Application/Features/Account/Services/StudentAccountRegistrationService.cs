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

        public async Task<bool> AddAccount(StudentAccountRegistrationDTO dto)
        {
            await _studentAccountRegistration.AddAccountAsync(dto);
            return true;
        }

        public async Task RegisterAccount(StudentAccountRegistrationDTO dto, int Id)
        {
            await _studentAccountRegistration.RegisterAccount(dto, Id);
        }

        public async Task<bool> SignIn (StudentAccountRegistrationDTO dto)
        {
            if(string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
            {
                return false;
                throw new NullReferenceException("Email ang Password cannot be null!");
            }
            return await _studentAccountRegistration.SignIn(dto);
        }


        public async Task<bool> VerifyEmail(StudentAccountRegistrationDTO verifyEmail)
        {
            var Verify = await _studentAccountRegistration.VerifyEmail(verifyEmail);
            if (Verify)
            {
                return true;
            }
            return false;
        }


        public async Task Logout()
        {
            await _studentAccountRegistration.Logout();
        }



    }
}
