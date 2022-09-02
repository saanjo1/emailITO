using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace EmailAppITO.ViewModels
{
    public class EmailManageViewModel
    {
        public int Id { get; set; }

        [Display(Name = "From email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string FromEmailAddress { get; set; }

        [Display(Name = "To email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")] 
        public string ToEmailAddress { get; set; }
        public string CCEmailAdresses { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Importance { get; set; }
        [Required]
        public string EmailContent { get; set; }

      

        

    }

    
}
