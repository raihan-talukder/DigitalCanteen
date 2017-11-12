using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entites
{
    public class AccountDetail
    {
        [Key, ForeignKey("UserDetails")]
        public int UserId { get; set; }

        public int Balance { get; set; }
        public int Refil { get; set; }

        public virtual UserDetail UserDetail { get; set; }
        public virtual ICollection<Item> Items { get; set; } 
    }
}