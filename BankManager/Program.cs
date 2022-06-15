using BankManager.Data;
using BankManager.Data.Models;
using System;
using System.Collections.Generic;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new BankManagerDbContext();

           // SeedDatabase(ctx);
            SeedDatabase2(ctx);
            SeedDatabase3(ctx);
        }

        private static Users SeedDatabase(BankManagerDbContext ctx)
        {
            Users user1 = new()
            {
                Name = "Georgi Kolev",
                Age = 34,
                Email = "gkolev21@dd.com",
                Phone = 12311231,
                Password = "1234",
                Role = "User"
            };

            Users user2 = new()
            {
                Name = "Ivailo Gudev",
                Age = 24,
                Email = "igudev4@dd.com",
                Phone = 123434,
                Password = "5678",
                Role = "Manager"
            };

            Users user3 = new()
            {
                Name = "Viktoriq Ivanova",
                Age = 34,
                Email = "vivanova14@dd.com",
                Phone = 4542819,
                Password = "1256",
                Role = "Admin"
            };




            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            ctx.Users.Add(user1);
            ctx.Users.Add(user2);
            ctx.Users.Add(user3);


            ctx.SaveChanges();
            return user1;
        }
        private static Banks SeedDatabase2(BankManagerDbContext ctx)
        {
            Banks bank1 = new()
            {
                Manager = "Violeta Georgieva",
                BankName = "DSK",
                Owner = "Todor Simeonov",
                Support = "Ivan Bakalov"
            };
            Banks bank2 = new()
            {
                Manager = "Simona Ivanova",
                BankName = "Fibank",
                Owner = "Aneliq Lilova",
                Support = "Ana Lazova"
            };
            Banks bank3 = new()
            {
                Manager = "Zornica Stoeva",
                BankName = "Raiffsen Bank",
                Owner = "Ivan Sotirov",
                Support = "Antonio Vachev"
            };
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            ctx.Banks.Add(bank1);
            ctx.Banks.Add(bank2);
            ctx.Banks.Add(bank3);

            ctx.SaveChanges();
            return bank1;
        }

        private static BankAccounts SeedDatabase3(BankManagerDbContext ctx)
        {
            BankAccounts bacc1 = new()
            {
                Money = 1245,
                AccNumber = 111111111,
                Owner = "Georgi Kolev"
            };
            BankAccounts bacc2 = new()
            {
                Money = 6589,
                AccNumber = 222222222,
                Owner = "Vanesa Georgieva"
            };
            BankAccounts bacc3 = new()
            {
                Money = 32678,
                AccNumber = 333333333,
                Owner = "Radoslav Kirilov"
            };

            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            ctx.BankAccounts.Add(bacc1);
            ctx.BankAccounts.Add(bacc2);
            ctx.BankAccounts.Add(bacc3);

            ctx.SaveChanges();
            return bacc1;
        }
    }
}
