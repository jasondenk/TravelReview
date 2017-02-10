using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //All Reviews get attached to a Category name that have been picked for them
        public virtual ICollection<Review> Reviews { get; set; }
    }
}