using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Data.Models
{
    public class BankAccounts
    {
        public int Id { get; set; }
        public double Money { get; set; }
        public int AccNumber { get; set; }
        public string Owner { get; set; }
        public Banks Bank { get; set; }
        public int BankId { get; set; }
    }
}
