using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.DTOs
{
    public class EventDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
        public int CreatorUserId { get; set; }
    }
}
