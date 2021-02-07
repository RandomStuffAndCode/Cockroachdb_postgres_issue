using ConsoleApp1.Data;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var db = new DataMainDbContextCockroach())
            {
                db.Database.EnsureCreated();

                var now = DateTime.Now;
                var account = new Account
                {
                    ConfiguratorIdentityName = "abc-123",
                    Created = now,
                    LastChanged = now,
                    Email = "my@email.com"
                };
                db.Accounts.Add(account);
                db.SaveChanges();

                Console.WriteLine($"SUCCESS. Id created: {account.Id}");
            }
        }
    }
}
