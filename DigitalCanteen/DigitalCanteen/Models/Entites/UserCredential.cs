using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entites
{
    public class UserCredential
    {
        [Key, ForeignKey("UserDetails")]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }
        public string UserType { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}