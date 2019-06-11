import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventComponent } from './event/event.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ScheduledComponent } from './scheduled/scheduled.component';
import { NotstartedComponent } from './notstarted/notstarted.component';
import { InviteComponent } from './invite/invite.component';
import { EditComponent } from './edit/edit.component';
import { CreateComponent } from './create/create.component';
import { SignUpComponent } from './sign-up/sign-up.component';



@NgModule({
  declarations: [
    AppComponent,
    EventComponent,
    LoginComponent,
    HomeComponent,
    ScheduledComponent,
    NotstartedComponent,
    InviteComponent,
    EditComponent,
    CreateComponent,
    SignUpComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
