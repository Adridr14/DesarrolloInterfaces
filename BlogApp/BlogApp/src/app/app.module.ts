import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { ListaComponent } from './lista/lista.component';
import { PieComponent } from './pie/pie.component';
import { PostComponent } from './lista/post/post.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    ListaComponent,
    PieComponent,
    PostComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
