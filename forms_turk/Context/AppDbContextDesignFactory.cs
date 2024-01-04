using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Context
{

    public class AppDbContextDesignFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-NKF0DJ1C\\SQLEXPRESS;" +
                    "Initial Catalog=turk_konveksiyon4;" +
                    "Integrated Security=True;Encrypt=True;" +
                    "Trust Server Certificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
