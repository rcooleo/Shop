using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games_Person>().HasKey(gp => new
            {
                gp.GameId,
                gp.PersonId
            });

            modelBuilder.Entity<Games_Person>().HasOne(p => p.Persons).WithMany(gp => gp.OwnedGames).HasForeignKey(p => p.PersonId);
            modelBuilder.Entity<Games_Person>().HasOne(p => p.Games).WithMany(gp => gp.OwnedGames).HasForeignKey(p => p.GameId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Games_Person> Games_Persons { get; set; }
    }
}
