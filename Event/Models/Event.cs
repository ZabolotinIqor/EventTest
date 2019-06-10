using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
        public int CreatorUserId { get; set; }
        public virtual ICollection<EventUser> eventUser { get; set; }

    }
}
