using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GCPAPi.Models
{
    public class SecurityAPIContext : DbContext
    {
        public SecurityAPIContext(DbContextOptions<SecurityAPIContext> options)
            : base(options)
        {
        }

        public DbSet<GCPAPi.Models.Security> Security { get; set; }
    }
}
