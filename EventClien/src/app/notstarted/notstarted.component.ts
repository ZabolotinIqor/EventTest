import { NotstartService } from './Services/notstart.service';
import { Component, OnInit } from '@angular/core';
import { eventDTO } from '../event/Models/eventDTO';

@Component({
  selector: 'app-notstarted',
  templateUrl: './notstarted.component.html',
  styleUrls: ['./notstarted.component.scss']
})
export class NotstartedComponent implements OnInit {


  events: eventDTO[] = [];
  constructor(private notstartedService: NotstartService) { }

  ngOnInit() {
    this.notstartedService.getUpcomingEvents().subscribe((res: eventDTO[]) => {
      this.events = res;
    });
  }

}
