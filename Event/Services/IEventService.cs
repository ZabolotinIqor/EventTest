using Event.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Services
{
    public interface IEventService
    {
        Task<Models.Event> CreateEvent(Models.Event eventModel);
        Task InvitePeopleToEvent(InviteDTO invite);
        Task CanselEvent(int id);
        Task<IEnumerable<Models.Event>> GetEvents();

    }
}
