using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entities
{
    public class UserCredential
    {
        
        [Key, ForeignKey("UserDetail")]
        public int UserId { get; set; }
        [Required, MaxLength(10), MinLength(5)]
        public string Username { get; set; }
        [Required, MaxLength(10), MinLength(5)]
        public string Password { get; set; }
       
        [Required]
        public int UserType { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}