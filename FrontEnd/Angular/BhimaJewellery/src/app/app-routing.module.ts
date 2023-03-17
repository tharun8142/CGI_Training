import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddJewelleryComponent } from './add-jewellery/add-jewellery.component';
import { ShowStockComponent } from './show-stock/show-stock.component';

const routes: Routes = [
  
{path:'addjewellery',component:AddJewelleryComponent},
{path:'show-jewellery',component:ShowStockComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
