using System.ComponentModel.DataAnnotations;

namespace PhotoBlog.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string PhotoName { get; set; }

        [Required, MaxLength(140)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation Prop
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
