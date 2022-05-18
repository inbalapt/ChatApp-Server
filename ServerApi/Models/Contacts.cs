using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class Contacts
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Server")]
        [Required]
        public string Server { get; set; }


        [Display(Name = "Last")]
        public string last { get; set; }

        [Display(Name = "LastDate")]
        public string lastdate { get; set; }


    }
}