import { Injectable } from '@angular/core';
import { environment } from '../../Shared/evironment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { eventDTO } from '../../event/Models/eventDTO';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ScheduleService {
  private api = environment.apiEndpoint + '/api/Event/';

  constructor(private httpClient: HttpClient) { }

  getUpcomingEvents() {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient
      .get<eventDTO[]>(`${this.api}GetEventsByUserId`, { headers })
      .pipe(
        tap(data => data)
      );
  }
}
