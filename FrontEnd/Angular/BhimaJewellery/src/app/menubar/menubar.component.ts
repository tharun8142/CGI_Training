import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menubar',
  templateUrl: './menubar.component.html',
  styleUrls: ['./menubar.component.css']
})
export class MenubarComponent implements OnInit{
  constructor(private router:Router) { }

  ngOnInit(): void {
  }
AddHandler(){
this.router.navigate(['addjewellery'])
}

}
