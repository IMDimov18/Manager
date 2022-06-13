using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Data.Models
{
    public class Banks
    {
        public int Id { get; set; }
        public string Manager { get; set; }
        public string Owner { get; set; }
        public string Support { get; set; }

        public Users User { get; set; }
        public int UserId { get; set; }
    }
}
