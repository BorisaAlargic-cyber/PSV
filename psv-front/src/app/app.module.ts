import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input'
import { MatCardModule } from '@angular/material/card';
import { FeedbackComponent } from './feedback/feedback.component';
import { AddFeedbackComponent } from './add-feedback/add-feedback.component'
import { MatTableModule } from '@angular/material/table'
import { HttpClientModule } from '@angular/common/http';
import { UserService } from './services/userService';
import { TokenService } from './services/tokenService';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegistrationComponent,
    FeedbackComponent,
    AddFeedbackComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule, ReactiveFormsModule,
    CommonModule,
    MatButtonModule, MatFormFieldModule, MatInputModule,
    MatCardModule,
    MatTableModule,
    HttpClientModule
  ],
  providers: [UserService, TokenService],
  bootstrap: [AppComponent]
})
export class AppModule { }
