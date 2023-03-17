import { compileDeclareComponentFromMetadata } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Goldornament } from '../model/goldornament';
import { Jewellery } from '../services/jewellery';

@Component({
  selector: 'app-add-jewellery',
  templateUrl: './add-jewellery.component.html',
  styleUrls: ['./add-jewellery.component.css']
})
export class AddJewelleryComponent implements OnInit {
  go:Goldornament = new Goldornament();

  constructor(public js:Jewellery) {}

  ngOnInit(): void {
    
  }
  addJewellery(){
     this.js.addOrnament(this.go);
    this.go=new Goldornament();
 }

}
