import { Injectable } from '@angular/core';
import { of, Observable } from "rxjs";

import { Employee } from "./employee";
import { Employees } from "./mock-employees";
import { MessageService } from "./message.service";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor( private messageService : MessageService) { }

  getEmployees(): Observable<Employee[]>{
    this.messageService.add('EmployeeService: fethed data');
    return of(Employees);
  }
 
}
