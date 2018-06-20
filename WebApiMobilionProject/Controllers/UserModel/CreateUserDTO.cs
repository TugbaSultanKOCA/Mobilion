using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMobilionProject.Controllers.UserModel
{
    public class CreateUserDTO
    {

      
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Required Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name Must be Minimum 2 Charaters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Lastname")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Lastname Must be Minimum 2 Charaters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required Username")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Username Must be Minimum 2 Charaters")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required Password")]
        [MaxLength(30, ErrorMessage = "Password cannot be Greater than 30 Charaters")]
        [StringLength(29, MinimumLength = 6, ErrorMessage = "Password Must be Minimum 6 Charaters")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Required IdentificationCode")]
        [StringLength(11, ErrorMessage = "IdentificationCode Must be 11 Charaters")]
        public string IdentificationCode { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Required PhoneNumber")]
        [StringLength(13, ErrorMessage = "PhoneNumber Must be 13 Charaters and +90xxxyyyzztt")]
        public string PhoneNumber { get; set; }

        [MaxLength(250, ErrorMessage = "Address cannot be Greater than 250 Charaters")]
        public string Address { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required FreeTextName")]
        [MaxLength(50, ErrorMessage = "FreeTextName cannot be Greater than 50 Charaters")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "FreeTextName Must be Minimum 6 Charaters")]
        public string FreeTextName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required FreeTextContent")]
        [MaxLength(250, ErrorMessage = "FreeTextContent cannot be Greater than 250 Charaters")]
        public string FreeTextContent { get; set; }
    
    }
}
