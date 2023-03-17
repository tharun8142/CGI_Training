import { Component, OnInit } from '@angular/core';
import { Goldornament } from '../model/goldornament';
import { Jewellery } from '../services/jewellery';

@Component({
  selector: 'app-show-stock',
  templateUrl: './show-stock.component.html',
  styleUrls: ['./show-stock.component.css']
})

  export class ShowStockComponent implements OnInit{
   gc:Array<Goldornament>=[] 
    constructor(public js:Jewellery) { 
      this.js.getornment().subscribe(
        (success)=>{
        this.gc=success;
        }
      )
    }
    ngOnInit(): void {

      
    }
    

}
