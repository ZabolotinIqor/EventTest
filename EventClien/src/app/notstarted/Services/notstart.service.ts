import { tap } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { eventDTO } from 'src/app/event/Models/eventDTO';
import { environment } from '../../Shared/evironment';

@Injectable({
  providedIn: 'root'
})
export class NotstartService {
  private api = environment.apiEndpoint + '/api/Event/';

  constructor(private httpClient: HttpClient) { }

  getUpcomingEvents() {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient
      .get<eventDTO[]>(`${this.api}GetUpcomingEvents`, { headers })
      .pipe(
        tap(data => data)
      );
  }
}
