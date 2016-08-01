using System.ComponentModel.DataAnnotations;

namespace KPITV.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
