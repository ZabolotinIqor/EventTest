import { Component, OnInit } from '@angular/core';
import { createPostDTO } from './Models/createPostDTO';
import { CreateService } from './services/create.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {

  EventModel: createPostDTO = new createPostDTO();
  constructor(private createService: CreateService) { }

  ngOnInit() {
    this.EventModel.creatorId = JSON.parse(localStorage.getItem('currentUser')).id;
  }
  create() {
    this.createService.createEvent(this.EventModel).subscribe((res: any) => {
      console.log(res);
    });
  }
}
