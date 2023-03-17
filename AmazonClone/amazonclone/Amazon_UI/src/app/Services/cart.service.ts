import { Injectable } from '@angular/core';
import { Items } from '../Models/items';

@Injectable({
  providedIn: 'root'
})
export class CartService {

    private items: Array<Items> = [];
    getCount():number{
      return this.items.length;
    }

    addItem(item: Items) {
      this.items.push(item);
      //call cart service post  method
    }
  
    removeItem(item: Items) {
      const index = this.items.indexOf(item);
      if (index > -1) {
        this.items.splice(index, 1);
      }
    }
  
    getTotalValue(): number {
      let total = 0;
      for (const item of this.items) {
        total += item.price * item.qty;
      }
      return total;
    }
  
    getTotalQuantity(): number {
      let quantity = 0;
      for (const item of this.items) {
        quantity += item.qty;
      }
      return quantity;
    }
  
    getItems(): Items[] {
      return this.items;
    }
  
    clearCart() {
      this.items = [];
    }
  }
  