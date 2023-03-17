import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  name:string=""
mobileno:string =""
email:string=""
password:string=""

  constructor() { }

  ngOnInit(): void {
  }
registerClick(){
  alert(this.name+this.password+this.email+this.mobileno);
}
cancelClick(){alert('cancel is working')}
inputChange(){
  alert('hi')
}

}
