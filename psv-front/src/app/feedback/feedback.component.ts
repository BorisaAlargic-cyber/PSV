import { Component, OnInit } from '@angular/core';

export interface Feedback {
  user: string,
  comment: string
}

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.scss']
})
export class FeedbackComponent implements OnInit {

  elements: Feedback[] = [
    { user: 'test1@gmail.com', comment: 'Comment 1'},
    { user: 'test2@gmail.com', comment: 'Comment 2'},
    { user: 'test3@gmail.com', comment: 'Comment 3'}
  ]
  displayedColumns: string[] = ['user', 'comment']

  constructor() { }

  ngOnInit(): void {
  }

}
