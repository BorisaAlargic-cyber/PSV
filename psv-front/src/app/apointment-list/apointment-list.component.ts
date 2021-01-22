import { Component, OnInit } from '@angular/core';
import { ApointmentService } from '../services/apointmentService';

export interface Apointment{
  paitent: string,
  doctor: string,
  date : string,
}

@Component({
  selector: 'app-apointment-list',
  templateUrl: './apointment-list.component.html',
  styleUrls: ['./apointment-list.component.scss']
})
export class ApointmentListComponent implements OnInit {

  elements: Apointment[] = []
  displayedColumns: string[] = ['patient', 'date' , 'doctor','taken']

  constructor(private apointmentService : ApointmentService) { }


  ngOnInit(): void {
    this.apointmentService.getApointment().subscribe(data =>{
      this.elements = data['entities'];
      console.log(data);
    })
  }

}
