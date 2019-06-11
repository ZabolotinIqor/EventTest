import { tap } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../Shared/evironment';
import { invitePostDTO } from '../Models/invitePostDTO';

@Injectable({
  providedIn: 'root'
})
export class InviteService {

  private apiUrl = environment.apiEndpoint + '/api/Event/InvitePeopleToEvent';

  constructor(private httpClient: HttpClient) { }

  invite(invitePostDTO: invitePostDTO) {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient.post<invitePostDTO[]>(this.apiUrl, invitePostDTO, { headers })
            .pipe(tap(data => {
                if (data != null) {
                    return data;
                } else {
                  return null;
                }
            }));
  }

}
