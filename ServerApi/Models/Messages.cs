using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class Messages
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }
     

        [Required]
        [Display(Name = "Created")]
        public string Created { get; set; }


        [Required]
        [Display(Name = "Sent")]
        public Boolean Sent { get; set; } 



    }
}
