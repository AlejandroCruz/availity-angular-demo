import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { ToastrModule } from 'ngx-toastr'

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LoginDetailsComponent } from './login-details/login-details.component';
import { LoginDetailsFormComponent } from './login-details/login-details-form/login-details-form.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginDetailsComponent,
    LoginDetailsFormComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
