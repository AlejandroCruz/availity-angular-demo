import { Injectable } from '@angular/core';
import { LoginDetails } from './login-details.model';

@Injectable({
  providedIn: 'root'
})
export class LoginDetailsService {

  constructor() { }

  formData: LoginDetails = new LoginDetails();
}
