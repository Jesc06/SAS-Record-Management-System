﻿using System.ComponentModel.DataAnnotations;

namespace Student_Record_Management_System.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Year of birth is required")]
        public string YearOfBirth { get; set; }

        [Required(ErrorMessage = "Month of birth is required")]
        public string MonthOfBirth { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "Home address is required")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Program is required")]
        public string Program { get; set; }

        [Required(ErrorMessage = "Year level is required")]
        public string YearLevel { get; set; }

        [Required(ErrorMessage = "Student Id is required")]
        public string StudentID { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare(nameof(Password),ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }
    }
}
