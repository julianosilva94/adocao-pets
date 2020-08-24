import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {DefaultLayoutComponent} from './layouts/default-layout/default-layout.component';
import {NavbarComponent} from './components/navbar/navbar.component';
import { PetCardComponent } from './components/pet-card/pet-card.component';
import { PetCardDeckComponent } from './components/pet-card-deck/pet-card-deck.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    DefaultLayoutComponent,
    NavbarComponent,
    PetCardComponent,
    PetCardDeckComponent,
    HomePageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
