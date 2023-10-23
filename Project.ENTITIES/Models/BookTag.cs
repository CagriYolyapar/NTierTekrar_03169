using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class BookTag:BaseEntity
    {
        public int BookID { get; set; }
        public int TagID { get; set; }

        //Relational Properties
        public virtual Book Book { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
