import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MapComponent } from './map/map.component';
import { IncidentListComponent } from './incident-list/incident-list.component';
import { IncidentDetailsComponent } from './incident-details/incident-details.component';
import {AppRoutingModule} from "./app.routing.modules";

@NgModule({
  declarations: [
    AppComponent,
    MapComponent,
    IncidentListComponent,
    IncidentDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
