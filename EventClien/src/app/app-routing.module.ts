import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';
import { InviteComponent } from './invite/invite.component';
import { NotstartedComponent } from './notstarted/notstarted.component';
import { ScheduledComponent } from './scheduled/scheduled.component';
import { EventComponent } from './event/event.component';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent,
    data: { title: 'Sign in' }
  },
  {
    path: 'home',
    component: HomeComponent,
    data: { title: 'Welcome to Event Service' }
  },
  { path: '',
  component: HomeComponent,
  children: [
  {
    path: 'create',
    component: CreateComponent
  },
  {
    path: 'edit',
    component: EditComponent
  },
  {
    path: 'invite',
    component: InviteComponent
  },
  {
    path: 'notstarted',
    component: NotstartedComponent
  },
  {
    path: 'scheduled',
    component: ScheduledComponent
  },
  {
    path: 'event',
    component: EventComponent
  }
]}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
