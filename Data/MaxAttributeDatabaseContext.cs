using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MaxAttributeMVC.Models
{
    public class MaxAttributeDatabaseContext : DbContext
    {
        public MaxAttributeDatabaseContext (DbContextOptions<MaxAttributeDatabaseContext> options)
            : base(options)
        {
        }

       
        public DbSet<MaxAttributeMVC.Models.MaxAttribute> MaxAttribute { get; set; }
    }
}
