using System.ComponentModel.DataAnnotations;

namespace IdNet6.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
