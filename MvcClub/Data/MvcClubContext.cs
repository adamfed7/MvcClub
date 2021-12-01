using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcClub.Models;

namespace MvcClub.Data
{
    public class MvcClubContext : DbContext
    {
        public MvcClubContext (DbContextOptions<MvcClubContext> options)
            : base(options)
        {
        }

        public DbSet<MvcClub.Models.Player> Player { get; set; }
    }
}
