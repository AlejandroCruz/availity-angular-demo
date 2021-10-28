import { Component, OnInit } from '@angular/core';
import { LoginDetailsService } from 'src/app/shared/login-details.service';

@Component({
  selector: 'app-login-details-form',
  templateUrl: './login-details-form.component.html',
  styles: [
  ]
})
export class LoginDetailsFormComponent implements OnInit {

  constructor(public service: LoginDetailsService) { }

  ngOnInit(): void {
  }

}
