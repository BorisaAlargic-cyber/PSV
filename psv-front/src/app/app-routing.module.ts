import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddFeedbackComponent } from './add-feedback/add-feedback.component';
import { AppComponent } from './app.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'login', component: LoginComponent },
  { path: 'registration', component: RegistrationComponent },
  { path: 'add-feedback', component: AddFeedbackComponent },
  { path: 'feedback', component: FeedbackComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
