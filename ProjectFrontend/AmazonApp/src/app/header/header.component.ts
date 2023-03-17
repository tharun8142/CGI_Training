import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserserviceService } from '../Services/userservice.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  constructor(private router:Router,public s:UserserviceService){}
  LoginHandel(){
    this.router.navigate(['Login'])
  }
  Seller(){
    this.router.navigate(['sellerL'])
  }
  RegisterHandel(){
    this.router.navigate(['Register'])
  }

  
  ngOnInit(): void {
    
  }



}
