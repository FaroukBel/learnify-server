using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace learnify.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }
        public string? Price { get; set; }
        public string? Category { get; set; }
        public string? Level { get; set; }
        public string? Language { get; set; }
        public byte[]? Image { get; set; }
    }
}