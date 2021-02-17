using System;
using Microsoft.EntityFrameworkCore;

namespace WaterProject.Models
{
    public class CharityDBContext : DbContext
    {
        public CharityDBContext (DbContextOptions<CharityDBContext> options):base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
