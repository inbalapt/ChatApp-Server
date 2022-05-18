using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Server")]
        [Required]
        public string Server { get; set; }



        [Display(Name = "last")]
        [Required]
        public string last { get; set; }


        [Display(Name = "lastdate")]
        [Required]
        public string lastdate { get; set; }

        public List<Contacts> Contacts { get; set; }
    }
}
