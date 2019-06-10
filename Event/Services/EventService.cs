using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.DTOs;
using Event.EntityFramework;
using Event.Models;
using Microsoft.EntityFrameworkCore;

namespace Event.Services
{
    public class EventService : IEventService
    {
        private readonly EventDbContext context;

        public EventService(EventDbContext context)
        {
            this.context = context;
        }
        public async Task CanselEvent(int id)
        {
            var res = context.Events.FirstOrDefault(p => p.Id == id);
            context.Events.Remove(res);
            await context.SaveChangesAsync();
        }

        public async Task<Models.Event> CreateEvent(Models.Event eventModel)
        {
            var _event = new Models.Event()
            {
                Name = eventModel.Name,
                Description = eventModel.Description,
                CreationDate = DateTime.Now,
                StartDate= eventModel.StartDate,
                LastDate=eventModel.LastDate,
                CreatorUserId = eventModel.CreatorUserId
            };
            await context.Events.AddAsync(_event);
            await context.SaveChangesAsync();
            return _event;
        }

        public async Task<IEnumerable<Models.Event>> GetEvents()
        {
            return await context.Events.ToListAsync();
        }

        public async Task<IEnumerable<Models.Event>> GetUpcomingEvents()
        {
            return await context.Events.Where(p => p.StartDate < DateTime.Now).ToListAsync();
        }

        public async Task<IEnumerable<Models.Event>> GetEventsByUserId(int id)
        {
            return await context.Events.Where(p => p.eventUser.Any(o => o.UserId == id)).ToListAsync();
        }

        public async Task InvitePeopleToEvent(InviteDTO invite)
        {
            var user = await context.User.FirstOrDefaultAsync(p => p.Email == invite.Email);
            var _event = await context.Events.FirstOrDefaultAsync(p => p.Id == invite.EventId);
          //  _event.eventUser.ToList().Add(user);
            await context.SaveChangesAsync();


        }

        public async Task<Models.Event> UpdateEvent(Models.Event eventModel)
        {
            var _event = await context.Events.FirstOrDefaultAsync(p => p.Id == eventModel.Id);
            _event.Name = eventModel.Name;
            _event.Description = eventModel.Description;
            _event.StartDate = eventModel.StartDate;
            _event.LastDate = eventModel.LastDate;
            await context.SaveChangesAsync();
            return _event;
        }
    }
}
