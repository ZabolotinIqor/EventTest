import { tap } from 'rxjs/operators';
import { createPostDTO } from './../Models/createPostDTO';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../Shared/evironment';
@Injectable({
  providedIn: 'root'
})
export class CreateService {
  private apiUrl = environment.apiEndpoint + '/api/Event/CreateEvent';

  constructor(private httpClient: HttpClient) { }

  createEvent(createPostDTO: createPostDTO) {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient.post<createPostDTO[]>(this.apiUrl, createPostDTO, { headers })
            .pipe(tap(data => {
                if (data != null) {
                    return data;
                } else {
                  return null;
                }
            }));
  }
}
