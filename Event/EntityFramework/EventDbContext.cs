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

    }
}
