import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginDetails } from './login-details.model';

@Injectable({
  providedIn: 'root'
})
export class LoginDetailsService {

  readonly baseUrl = 'http://localhost:5000/api/LoginDetails';
  
  constructor(private http:HttpClient) { }

  formData: LoginDetails = new LoginDetails();

  postLoginDetails(){
    return this.http.post(this.baseUrl, this.formData);
  }
}
