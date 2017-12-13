using System.ComponentModel.DataAnnotations;

namespace EricTangAspNet.Entities
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Review")]
        public string Text { get; set; }
        [Range(0, 5)]
        public int Rating { get; set; }
    }
}
