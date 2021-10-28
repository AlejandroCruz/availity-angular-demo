import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginDetailsComponent } from './login-details/login-details.component';
import { LoginDatailsFormComponent } from './login-details/login-datails-form/login-datails-form.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginDetailsComponent,
    LoginDatailsFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
