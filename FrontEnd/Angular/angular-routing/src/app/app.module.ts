import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AddJewelleryComponent } from './add-jewellery/add-jewellery.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './footer/footer.component';
import { MenubarComponent } from './menubar/menubar.component';

@NgModule({
  declarations: [
    AppComponent,MenubarComponent,FooterComponent,AddJewelleryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
