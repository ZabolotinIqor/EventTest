import { Injectable } from '@angular/core';
import { environment } from '../../Shared/evironment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { eventDTO } from '../Models/eventDTO';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  private api = environment.apiEndpoint + '/api/';

  constructor(private httpClient: HttpClient) { }

  getEvents() {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient
      .get<eventDTO[]>(`${this.api}getEvents`, { headers })
      .pipe(
        tap(data => data)
      );
  }
}
