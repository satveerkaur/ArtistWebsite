using ArtistWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Artists> artists { get; set; }
        public DbSet<ArtCollection> artCollection { get; set; }
        public DbSet<Supplies> supplies { get; set; }
        public DbSet<ArtCourses> artCourses { get; set; }
        public DbSet<Events> events { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }
    }
}
