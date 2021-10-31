import { Component, OnInit } from '@angular/core';
import { LoginDetails } from 'src/app/shared/login-details.model';
import { LoginDetailsService } from 'src/app/shared/login-details.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login-details-form',
  templateUrl: './login-details-form.component.html',
  styles: [
  ]
})
export class LoginDetailsFormComponent implements OnInit {

  constructor(
    public service: LoginDetailsService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    this.service.postLoginDetails().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Registration success.', 'Login Registration');
      },
      err => {
        console.error();
        this.toastr.error('Registration error.', 'Login Registration');
      }
    );
  }

  resetForm(form: NgForm){
    form.form.reset();
    this.service.formData = new LoginDetails();
  }
}
