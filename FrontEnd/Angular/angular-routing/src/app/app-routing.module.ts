import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddJewelleryComponent } from './add-jewellery/add-jewellery.component';

const routes: Routes = [
  {path:'addjewellery',component:AddJewelleryComponent}
];
 
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
