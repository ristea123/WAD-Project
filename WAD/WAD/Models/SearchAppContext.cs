using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class SearchAppContext : IdentityDbContext<IdentityUser>
    {
        public SearchAppContext(DbContextOptions<SearchAppContext> options) : base(options)
        { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Reviewer> Reviews { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
