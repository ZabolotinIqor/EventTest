import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { environment } from '../../Shared/evironment';
import { loginDTO } from '../Models/loginDTO';
import { tap, catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private apiUrl = environment.apiEndpoint + '/api/User/login';

  constructor(private route: Router,private httpClient:HttpClient) { }

  loginUser(loginmodel: loginDTO){
    console.log("service works");
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient.post<any>(this.apiUrl, loginmodel, { headers })
    .pipe(map(user => {
      if (user) {
          localStorage.setItem('currentUser', JSON.stringify(user));
      }
      return user;
  }));
  }
}
