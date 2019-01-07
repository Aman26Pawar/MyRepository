import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  message : string[] = [];

  add(msg : string){
    this.message.push(msg);
  }

  clear(){
    this.message = [];
  }
  constructor() { }
}
