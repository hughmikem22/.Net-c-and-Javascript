using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Personal2Project.Data;

namespace Personal2Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Personal2Project.Data.PhotoStorage> PhotoStorage { get; set; }
        public DbSet<Personal2Project.Data.VideoStorage> VideoStorage { get; set; }
        
       
    }
}
