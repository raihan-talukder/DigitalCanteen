using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entities
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Fullname Required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Department Required")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number Required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "DateofBith Required")]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
   
      
        public virtual UserCredential UserCredential { get; set; }

    }
}
