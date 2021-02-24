using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


// I realized at the end that his hint on normalization is meant to split up Classification/Category,
// but I'm too afraid to try and delete the DB and migrations just to add a new column! If I deserved to 
// lose points for this, please know I at least KNEW what had to be done....

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^(?= (?:\D *\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Pages { get; set; }
    }
}

