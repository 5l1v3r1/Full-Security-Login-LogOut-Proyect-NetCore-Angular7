import { Injectable } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private formBuilder: FormBuilder) { }

  formModel = this.formBuilder.group({
    UserName: [''],
    Email: [''],
    FullName: [''],
    Passwords: this.formBuilder.group({
      Password: [''],
      ConfirmPassword: ['']
    })

  });
}
