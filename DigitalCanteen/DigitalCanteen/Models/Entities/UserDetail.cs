using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entities
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        [Required, StringLength(100)]
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
       
        [Required, StringLength(150)]
        public string Address { get; set; }
   
       
       
        public virtual UserCredential UserCredential { get; set; }

    }
}
