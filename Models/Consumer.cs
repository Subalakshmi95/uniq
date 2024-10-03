using System.ComponentModel.DataAnnotations;

namespace uniqAPI.Models
{
    public class Consumer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
