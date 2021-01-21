import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserService } from '../services/userService';
import { ApointmentService} from '../services/apointmentService';

@Component({
  selector: 'app-add-apointment',
  templateUrl: './add-apointment.component.html',
  styleUrls: ['./add-apointment.component.scss']
})
export class AddApointmentComponent implements OnInit {

  addAppointmentForm : FormGroup;
  doctors;

  constructor(private formBuilder: FormBuilder, private userService: UserService , private apointmentService : ApointmentService) { }

  ngOnInit(): void {
    this.addAppointmentForm = this.formBuilder.group({
      date: [null, Validators.required]
      
    });

    this.doctors = [];

    this.userService.getDoctors().subscribe(data => {
      this.doctors = data;

    });

  }



  submit() {}

}
