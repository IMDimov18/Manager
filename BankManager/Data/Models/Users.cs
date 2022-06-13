using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Data.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public ICollection<Banks> Banks { get; set; } = new HashSet<Banks>();
    }
}
