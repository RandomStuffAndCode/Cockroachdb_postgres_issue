using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public abstract class DataMainDbContextBase : DbContext
    {
        public DbSet<Account> Accounts => Set<Account>();
    }
}
