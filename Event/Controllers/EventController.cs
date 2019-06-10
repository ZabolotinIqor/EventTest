using Event.DTOs;
using Event.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [Route("api/[controller]")]
    public class EventController:Controller
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet("GetAllEvents")]
        public async Task<ActionResult> GetAllEvents()
        {
            var result = await eventService.GetEvents();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpDelete("CanselEvent")]
        public async Task<ActionResult> CanselEvent(int id)
        {
            var result = eventService.CanselEvent(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpPost("InvitePeopleToEvent")]
        public async Task<ActionResult> InvitePeopleToEvent([FromBody]InviteDTO invite)
        {
            if (ModelState.IsValid)
            {
                await eventService.InvitePeopleToEvent(invite);
                return Ok();
            }
            return BadRequest("Not correct query");
        }
        [HttpPost("CreateEvent")]
        public async Task<ActionResult> CreateEvent(Models.Event eventModel)
        {
            if (ModelState.IsValid)
            {
                var result = await eventService.CreateEvent(eventModel);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }

            return BadRequest();
        }
        [HttpPut("UpdateEvent")]
        public async Task<ActionResult> UpdateEvent(Models.Event eventModel)
        {
            if (ModelState.IsValid)
            {
                var result = await eventService.UpdateEvent(eventModel);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }

            return BadRequest();
        }
        [HttpGet("GetUpcomingEvents")]
        public async Task<ActionResult> GetUpcomingEvents()
        {
            var result = await eventService.GetUpcomingEvents();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpGet("GetEventsByUserId")]
        public async Task<ActionResult> GetEventsByUserId(int id)
        {
            var result = await eventService.GetEventsByUserId(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}

