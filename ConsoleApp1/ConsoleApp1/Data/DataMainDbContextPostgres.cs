using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class DataMainDbContextPostgres : DataMainDbContextBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            const string connectionStringPostgres = "host=localhost;port=5432;database=mydb;username=postgres;password=mypassword; Include Error Detail=true";
            options.UseNpgsql(connectionStringPostgres, o => o.SetPostgresVersion(9, 6))
                        .EnableSensitiveDataLogging();
        }

    }
}
