using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models
{
    public class Balance
    {
        [Key, ForeignKey("UserDetail")]
        public int UserId { get; set; }
        [Required]
        public float AvailableBalance { get; set; }

        public float Refil { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}