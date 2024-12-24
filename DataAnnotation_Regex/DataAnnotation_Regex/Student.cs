using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation_Regex
{
    internal class Student
    {
        [Required(ErrorMessage ="Name is required")]
        [StringLength(maximumLength:45, MinimumLength = 4, ErrorMessage ="Name should be between 4 and 45")]
        public string Name { get; set; }
        [Range(typeof(DateTime), "01/01/1990", "24/12/2024", ErrorMessage = "Valid dates for the Property {0} between {1} and {2}")]
        public DateTime EntryDate { get; set; }
        [Range(18, 60, ErrorMessage ="Age should be between 18 and 60")]
        public string Age { get; set; }
        [Required(ErrorMessage ="Email is valid")]
        [EmailAddress(ErrorMessage ="Email should be valid")]
        public string Email {  get; set; }
        public string Password { get; set; }
        [Compare("Student.Password", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string PasswordConfirmation { get; set; }

    }
}
