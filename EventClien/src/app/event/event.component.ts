import { Component, OnInit } from '@angular/core';
import { eventDTO } from './Models/eventDTO';
import { EventService } from './Services/event.service';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.scss']
})
export class EventComponent implements OnInit {

  events: eventDTO[] = [];
  constructor(private eventService: EventService) { }

  ngOnInit() {
    this.eventService.getEvents().subscribe((res: eventDTO[]) => {
      this.events = res;
    });
  }

}
