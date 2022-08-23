using Microsoft.EntityFrameworkCore;
using RewardSystem.Models;

namespace RewardSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerTransaction> CustomerTransactions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlite(@"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\CustomerRewardSystem.db");
        //    //options.UseSqlite(@"Data Source=F:\Code-Practice\Synergent\CustomerRewardSystem\CustomerRewardSystem.db");
        //}
    }
}
