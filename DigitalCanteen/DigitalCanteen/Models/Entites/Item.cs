using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalCanteen.Models.Entites
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int UseId { get; set; }

        public virtual AccountDetail AccountDetail { get; set; }

    }
}