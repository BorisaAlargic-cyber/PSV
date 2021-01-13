import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class FeedBackService
{
    baseUrl = 'https://localhost:44308';

    constructor(private http: HttpClient) { }

    feedback(data) {
        return this.http.post(this.baseUrl + '/api/feedback', data);
    }
}