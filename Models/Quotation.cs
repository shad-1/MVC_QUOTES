using System;
using System.ComponentModel.DataAnnotations;

namespace SpencersQualityQuotes.Models
{
	public class Quotation
	{
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Quote { get; set; }
        [Required]
        public string Author { get; set; }
        #nullable enable
        public string? Date { get; set; }
        public string? Subject { get; set; }
        public string? Citation { get; set; }

    }
}

