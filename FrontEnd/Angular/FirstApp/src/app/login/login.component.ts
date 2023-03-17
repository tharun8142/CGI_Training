import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  template: `
  Username <input type="text"/> <br>
  Password <input type="text"><br>
  <button>Login</button>
`,
styles: [
  `input{background-color: aqua;}`
]

})

export class LoginComponent implements OnInit {
  constructor() { }
  ngOnInit(): void {
  }
}
