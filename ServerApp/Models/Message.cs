using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Message
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Server")]
        public string Server { get; set; }

        [Required]
        [Display(Name = "Created")]
        public string Created { get; set; }

        [Required]
        [Display(Name = "From")]
        public Contacts From { get; set; }

        [Required]
        [Display(Name = "To")]
        public Contacts To { get; set; } 



    }
}
