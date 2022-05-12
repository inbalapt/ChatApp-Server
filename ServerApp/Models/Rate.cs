using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Rate
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Range(1,5)]
        [Required]
        public int Rating { get; set; }
    }
}
