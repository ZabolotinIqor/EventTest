import { ScheduleService } from './Services/schedule.service';
import { Component, OnInit } from '@angular/core';
import { eventDTO } from '../event/Models/eventDTO';

@Component({
  selector: 'app-scheduled',
  templateUrl: './scheduled.component.html',
  styleUrls: ['./scheduled.component.scss']
})
export class ScheduledComponent implements OnInit {

  events: eventDTO[] = [];
  constructor(private scheduleService: ScheduleService) { }

  ngOnInit() {
    this.scheduleService.getUpcomingEvents().subscribe((res: eventDTO[]) => {
      this.events = res;
    });
  }
}
