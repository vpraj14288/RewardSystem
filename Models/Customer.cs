using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace RewardSystem.Models
{
    [Index(nameof(UserName), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Customer
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId{ get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string UserName { get; set; }

        [EmailAddress]
        [MaxLength(250)]
        public string Email { get; set; }
    }
}
