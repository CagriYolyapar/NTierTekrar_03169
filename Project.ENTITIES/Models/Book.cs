using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public int PageNumber { get; set; }
        public int? ShelfID { get; set; }
        public int? AuthorID { get; set; }
        public int? CategoryID { get; set; }



        //Relational Properties
        public virtual Shelf Shelf { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<BookTag> BookTags { get; set; }


    }
}
