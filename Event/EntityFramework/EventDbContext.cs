using Event.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.EntityFramework
{
    public class EventDbContext:DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) :base(options){}

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Models.Event> Events { get; set; }
        public virtual DbSet<EventUser> EventUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventUser>()
                .HasKey(bc => new {bc.EventId, bc.UserId});

            modelBuilder.Entity<EventUser>()
                .HasOne(bc => bc.Event)
                .WithMany(b => b.eventUser)
                .HasForeignKey(bc => bc.EventId);

            modelBuilder.Entity<EventUser>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.userEvent)
                .HasForeignKey(bc => bc.UserId);
        }

    }
}
