using System;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;
using DigitalCanteen.Models.Entities;

namespace DigitalCanteen.Models.Entities
{
    public class AccountDetail
    {
        [Key]
        public int AccounNumber { get; set; }
        [Required,ForeignKey("UserDetail")]
        public int UserId { get; set; }
      

        [Required(ErrorMessage = "Initial balance Required")]

        public int InitialBalance { get; set; }

        public int Balance { get; set; }
        public int Refil { get; set; }

        public virtual UserDetail UserDetail { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}