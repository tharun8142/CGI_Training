import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core'
import { Observable } from 'rxjs';
import { Goldornament } from '../model/goldornament';
@Injectable({
    providedIn:'root'
})


export class Jewellery {
  
    gc:Array<Goldornament> = []
  constructor(private client:HttpClient) { }
  getornment():Observable<Array<Goldornament>>{
    return this.client.get<Array<Goldornament>>("http://localhost:5132/api/Gold")
  }

addOrnament(go:Goldornament){
  //this.gc.push(go);
   this.client.post<Goldornament>("http://localhost:5132/api/Gold",go)
  .subscribe(
    {
      next:(success)=>{console.log(success)},
      error:(error)=>console.log(error)
    }
      
  )
  }
  
}

  

