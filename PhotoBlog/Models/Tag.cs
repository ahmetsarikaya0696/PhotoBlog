using System.ComponentModel.DataAnnotations;

namespace PhotoBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        // Navigation Prop
        public List<Photo> Photos { get; set; }
    }
}
