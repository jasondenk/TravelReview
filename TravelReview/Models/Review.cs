using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Review
    {
        //Properties for the Review Class
        [Key]
        public int ID { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
        public DateTime Published { get; set; }

        //They are linked to the foreign Key "Category" because they all fall under a category of Vacation
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}