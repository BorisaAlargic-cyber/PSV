import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class DrugService
{
    baseUrl = 'https://localhost:44308';

    constructor(private http: HttpClient) { }

    getApointment(){
        this.http.get(this.baseUrl + '/api/users/getApointment');
    }
    addApointment(input){
        this.http.post(this.baseUrl + '/api/apointment/add',input);
    }




}