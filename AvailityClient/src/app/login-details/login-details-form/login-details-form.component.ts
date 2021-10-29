import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
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

  onSubmit(form:NgForm){
    this.service.postLoginDetails().subscribe(
      res => {},
      err => { console.error(); }      
    );
  }

}
