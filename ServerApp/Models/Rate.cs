using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Rate
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage ="This field is required!")]
        [MaxLength(15, ErrorMessage = "Please write a shorter name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(150, ErrorMessage = "Please write a shorter name")]
        public string Description { get; set; }

        [Display(Name = "Rating")]
        [Range(1,5, ErrorMessage ="Please select a rate between 1-5")]
        [Required(ErrorMessage = "This field is required!")]
        public int Rating { get; set; }
    }
}
