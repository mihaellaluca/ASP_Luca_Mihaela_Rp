using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Luca_Mihaela_Rp.Models;

namespace ASP_Luca_Mihaela_Rp.Data
{
    public class ASP_Luca_Mihaela_RpContext : DbContext
    {
        public ASP_Luca_Mihaela_RpContext (DbContextOptions<ASP_Luca_Mihaela_RpContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_Luca_Mihaela_Rp.Models.Movie> Movie { get; set; }
    }
}
