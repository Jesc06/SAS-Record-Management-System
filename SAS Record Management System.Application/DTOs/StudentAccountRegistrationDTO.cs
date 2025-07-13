using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS_Record_Management_System.Application.DTOs
{
    public class StudentAccountRegistrationDTO
    {
        [Required(ErrorMessage = "Firstname is required")]
        public required string FirstName { get; set; }


        [Required(ErrorMessage = "Middlename is required")]
        public required string Middlename { get; set; }


        [Required(ErrorMessage = "Lastname is required")]
        public required string LastName { get; set; }


        [Required(ErrorMessage = "Gender is required")]
        public required string Gender { get; set; }


        [Required(ErrorMessage = "Year of Birth is required")]
        public required int YearOfBirth { get; set; }


        [Required(ErrorMessage = "Month of Birth is required")]
        public required string MonthOfBirth { get; set; }


        [Required(ErrorMessage = "Date of Birth is required")]
        public required int DateOfBirth { get; set; }


        [Required(ErrorMessage = "Home Address is required")]
        public required string HomeAddress { get; set; }


        [Required(ErrorMessage = "Mobile number is required")]
        public required string MobileNumber { get; set; }


        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }


        [Required(ErrorMessage = "Program is required")]
        public required string Program { get; set; }


        [Required(ErrorMessage = "Year level is required")]
        public required string YearLevel { get; set; }


        [Required(ErrorMessage = "Student Id is required")]
        public required string StudentID { get; set; }


        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public required string ConfirmPassword { get; set; }
    }
}
