import { Component, OnInit } from '@angular/core';
import { GoldOrnament } from '../models/gold-ornament';
import { JewelleryService } from '../services/jewellery.service';

@Component({
  selector: 'app-add-jewellery',
  templateUrl: './add-jewellery.component.html',
  styleUrls: ['./add-jewellery.component.css']
})
export class AddJewelleryComponent implements OnInit {
 go:GoldOrnament = new GoldOrnament(0,"",0,"");
  constructor(public js:JewelleryService) {}
  ngOnInit(): void {
  }
  addJewellery(){
     
     this.js.addOrnament(this.go);
  }
}
