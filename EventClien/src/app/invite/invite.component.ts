import { Component, OnInit } from '@angular/core';
import { invitePostDTO } from './Models/invitePostDTO';
import { InviteService } from './Services/invite.service';

@Component({
  selector: 'app-invite',
  templateUrl: './invite.component.html',
  styleUrls: ['./invite.component.scss']
})
export class InviteComponent implements OnInit {

  InvitePost: invitePostDTO = new invitePostDTO();
  constructor(private inviteService: InviteService) { }

  ngOnInit() {
  }
  invite() {
    this.inviteService.invite(this.InvitePost).subscribe((res: any) => {
      console.log(res);
    });
  }
}
