
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
import { Component, OnInit } from '@angular/core';
 
import { EmployeeService } from '../shared/employee.service'
import { Employee } from '../shared/employee.model';
import { ToastrService } from 'ngx-toastr';    
@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
 
  constructor(private employeeService: EmployeeService,private toastr : ToastrService) { }
 
  ngOnInit() {
    this.employeeService.getEmployeeList();
  }
 
  showForEdit(emp: Employee) {
    this.employeeService.selectedEmployee = Object.assign({}, emp);;
  }
 
 
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record ?') == true) {
      this.employeeService.deleteEmployee(id)
      .subscribe(x => {
        this.employeeService.getEmployeeList();
        this.toastr.warning("Deleted Successfully","Employee Register");
      })
    }
  }
}