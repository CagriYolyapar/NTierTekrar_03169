using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AuthorProfile:BaseEntity
    {
        public string Biography { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? Deathdate { get; set; }

        //Relational Properties
        //güzel class
        //tesekkür ederim :)
        public virtual Author Author { get; set; }

    }
}
