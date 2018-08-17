import { Injectable } from '@angular/core';
import {Http,Response,Headers,RequestOptions,RequestMethod} from '@angular/http';
import { Observable} from 'rxjs';
//import { map } from 'rxjs/add/operator/map';
/*import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';*/

import {Employee } from './employee.model';
 
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  selectedEmployee : Employee;
  employeeList: Employee[]=[
    {EmployeeID:1,EmployeeName:"Aman",Department:"Dev"}
  ];
  constructor( http:Http) { }

  postEmployee(emp : Employee){
    var body = JSON.stringify(emp);
    var headerOptions = new Headers({'Content-Type':'application/json'})
    var requestOptions = new RequestOptions({method: RequestMethod.Post, headers:headerOptions});
    return this.http.post('http://localhost:53042/api/Employee',body,requestOptions).map(x => x.json());
  }


  putEmployee(id, emp){
    var body = JSON.stringify(emp);
    var headerOptions = new Headers({'Content-Type':'application/json'})
    var requestOptions = new RequestOptions({method: RequestMethod.Post, headers:headerOptions});
    return this.http.post('http://localhost:53042/api/Employee'+id,body,requestOptions).map((res:any) => res.json());
  }

  getEmployeeList(){
    this.http.get('http://localhost:53042/api/Employee')
    .map((data: Response)=>{
      return data.json() as Employee[];
    }).toPromise().then(x=>{
      this.employeeList=x;
    })
  }

  deleteEmployee(id:number){
    return this.http.delete('http://localhost:53042/'+id).map(res => res.json());
  }
}