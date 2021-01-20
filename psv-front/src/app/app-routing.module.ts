import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddDrugComponent } from './add-drug/add-drug.component';
import { AddFeedbackComponent } from './add-feedback/add-feedback.component';
import { AppComponent } from './app.component';
import { DrugListComponent } from './drug-list/drug-list.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { UserListComponent } from './user-list/user-list.component';
import { VisitComponent } from './visit/visit.component';


const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'login', component: LoginComponent },
  { path: 'registration', component: RegistrationComponent },
  { path: 'add-feedback', component: AddFeedbackComponent },
  { path: 'feedback', component: FeedbackComponent },
  { path: 'users', component: UserListComponent},
  { path: 'visits' , component:VisitComponent},
  { path: 'drugs' , component:DrugListComponent},
  { path: 'add-drug', component:AddDrugComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
