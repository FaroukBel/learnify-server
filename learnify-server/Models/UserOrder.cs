using System;
using System.ComponentModel.DataAnnotations;

namespace learnify.Models
{
    public class UserOrder
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int userId { get; set; }
        public int courseId { get; set; }
        public DateTime purchaseDate { get; set; }


    }
}