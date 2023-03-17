import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Models/user';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserserviceService  {
us:Array<User>=[]
  constructor(private client:HttpClient) { }
  
  login(us:User)
{
  this.client.post<User>("http://localhost:5129/api/User/V",us).subscribe(
    {
    next:(success)=>{console.log(success)},
    error:(error)=>console.log(error)
    }
    )

}
register(us:User)
{
  this.client.post<User>("http://localhost:5129/api/User/R",us).subscribe(
    {
    next:(s)=>{console.log(s)},
    error:(error)=>console.log(error)
    }
    )

}

}
