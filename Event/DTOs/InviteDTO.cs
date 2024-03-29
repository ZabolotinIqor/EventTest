﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.DTOs
{
    public class InviteDTO
    {
        public int EventId { get; set; }
        public string Email { get; set; }
        public string InvitationText { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
