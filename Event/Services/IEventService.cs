using Event.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Services
{
    public interface IEventService
    {
        Task<Models.Event> CreateEvent(EventDTO eventModel);
        Task CanselEvent(int id);
        Task<Models.Event> UpdateEvent(Models.Event eventModel);
        Task InvitePeopleToEvent(InviteDTO invite);
        Task<IEnumerable<Models.Event>> GetEvents();
        Task<IEnumerable<Models.Event>> GetUpcomingEvents();
        Task<IEnumerable<Models.Event>> GetEventsByUserId(int id);

    }
}
