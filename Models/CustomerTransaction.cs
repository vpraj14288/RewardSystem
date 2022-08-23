using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace RewardSystem.Models
{
    [Index(nameof(TransactionCode), IsUnique = true)]
    public class CustomerTransaction
    {
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required]
        public string TransactionCode { get; set; }

        [Required]

        public DateTime TransactionDatetime { get; set; }
        
        [Required]
        public int TransactionAmount { get; set; }
        public int TransactionReward { get; set; }

    }
}
