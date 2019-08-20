using System;
using System.ComponentModel.DataAnnotations;

namespace TietoAcademyDemo.Domain
{
    public class Book
    {
        [Key]
        public string isbn { get; set; }

        public string title { get; set; }
        public DateTime? publishDate { get; set; }
        public string publishPlace { get; set; }
        public int numberOfPages { get; set; }
        public string subject { get; set; }
        public string coverUrl { get; set; }
        public string publisher { get; set; }
    }
}
