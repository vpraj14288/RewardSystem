using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RewardSystem.Data;
using RewardSystem.Models;
using SQLitePCL;
using System.Transactions;

namespace RewardSystem.Controllers
{
    public class CustomerTransactionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerTransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddTransaction(CustomerTransaction custTrans)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var customerTransactions = from trans in _context.CustomerTransactions
                                       join customers in _context.Customers on trans.CustomerId equals customers.CustomerId
                                       select new
                                       {
                                           CustomerName = customers.UserName,
                                           TransactionCode = trans.TransactionCode,
                                           TransactionDatetime = trans.TransactionDatetime,
                                           TransactionAmount = trans.TransactionAmount,
                                           TransactionReward = trans.TransactionReward,
                                       };
            return View(customerTransactions);
        }

        public IActionResult CustomerMonthlyRewardSummary()
        {
            ViewData["CustomerTransactions"] = _context.CustomerTransactions;
            ViewData["Customers"] = _context.Customers;
            return View();
        }
    }
}
