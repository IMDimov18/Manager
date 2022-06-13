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
            var users = new List<Users>()
            {
                new Users() { Name="Georgi Kolev", Age=34, Email="gkolev21@dd.com", Phone=12311231, Password="1234", Role="User"},
                new Users() { Name="Ivailo Gudev", Age=34, Email="igudev4@dd.com", Phone=3445266, Password="5678", Role="Manager"},
                new Users() { Name="Viktoriq Ivanova", Age=34, Email="vivanova14@dd.com", Phone=4542819, Password="1256", Role="Admin"},
            };

            var banks = new List<Banks>()
            {
                new Banks() {Manager="Violeta Georgieva", BankName="DSK", Owner="Todor Simeonov", Support="Ivan Bakalov" },
                new Banks() {Manager="Simona Ivanova", BankName="Fibank", Owner="Aneliq Lilova", Support="Ana Lazova" },
                new Banks() {Manager="Zornica Stoeva", BankName="Raiffsen Bank", Owner="Ivan Sotirov", Support="Antonio Vachev" }
            };

            var bacc = new List<BankAccounts>()
            {
                new BankAccounts() {Money=1245, AccNumber=111111111, Owner="Georgi Kolev" },
                new BankAccounts() {Money=6589, AccNumber=222222222, Owner="Vanesa Georgieva" },
                new BankAccounts() {Money=32678, AccNumber=333333333, Owner="Radoslav Kirilov" },
            };
        }
    }
}
