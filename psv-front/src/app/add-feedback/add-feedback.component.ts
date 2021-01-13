import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-feedback',
  templateUrl: './add-feedback.component.html',
  styleUrls: ['./add-feedback.component.scss']
})
export class AddFeedbackComponent implements OnInit {

  addFeedbackForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.addFeedbackForm = this.formBuilder.group({
      comment: [null, Validators.required]
    });
  }

  submit() {
    
    if (!this.addFeedbackForm.valid) {
      return;
    }

    console.log(this.addFeedbackForm.value);
  }
}
