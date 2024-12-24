using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation_Regex
{
    internal class UserDetails
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(45, MinimumLength = 2, ErrorMessage = "Name should be between 2 and 45")]
        public string Name { get; set; }
        [Range(18, 70, ErrorMessage = "Age should be between 18 to 70")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Provide valid email input")]
        public string Email { get; set; }


      

    }
}
