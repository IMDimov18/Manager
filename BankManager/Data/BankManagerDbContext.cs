using BankManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Data
{
    public class BankManagerDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Banks> Banks { get; set; }
        public DbSet<BankAccounts> BankAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BankManager;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Banks>().ToTable("Banks");
            modelBuilder.Entity<BankAccounts>().ToTable("BankAccounts");
        }
    }
}
