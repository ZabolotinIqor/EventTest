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

        public Task InvitePeopleToEvent(InviteDTO invite)
        {
            throw new NotImplementedException();
        }
    }
}
