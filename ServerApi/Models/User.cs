using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        public string Password { get; set; }

        [Display(Name = "Server")]
        [Required]
        public string Server { get; set; }

        public List<Contacts> Contacts { get; set; }

        public List<Chats> Chats { get; set; }

    }
}
