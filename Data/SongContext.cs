using System;
using Microsoft.EntityFrameworkCore;
using Moment3API.Models;

namespace Moment3API.Data
{
    public class SongContext : DbContext 
    {
        public SongContext(DbContextOptions<SongContext> options) : base (options)
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}
