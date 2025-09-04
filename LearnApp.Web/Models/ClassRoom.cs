using System.ComponentModel.DataAnnotations;

namespace LearnApp.Web.Models
{
    public class ClassRoom
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
