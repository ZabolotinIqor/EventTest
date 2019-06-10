import { Component, OnInit } from '@angular/core';
import { LoginService } from './Services/login.service';
import { loginDTO } from './Models/loginDTO';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  LoginModel: loginDTO = new loginDTO();
  constructor(private loginService:LoginService,private route:Router) { }

  ngOnInit() {
  }
  onSubmit() {
    console.log("onSubmit works");
    this.loginService.loginUser(this.LoginModel).subscribe(
        response => {
            if (response.token != null ) {
                this.route.navigate(['home']);
            } else {
                this.route.navigate(['login']);
            }
        });

}
}
