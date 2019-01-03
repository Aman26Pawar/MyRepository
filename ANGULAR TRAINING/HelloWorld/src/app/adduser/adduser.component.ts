import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-adduser',
  templateUrl: './adduser.component.html',
  styleUrls: ['./adduser.component.css']
})
export class AdduserComponent implements OnInit {
 @Input('value') value;
 username: string ="";
  constructor() { }

  ngOnInit() {
  }

  SaveUser(){
    alert(this.username);
  }
}
