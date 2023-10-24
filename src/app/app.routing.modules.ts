import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IncidentListComponent } from './incident-list/incident-list.component';
import { IncidentDetailsComponent } from './incident-details/incident-details.component';
import { MapComponent } from './map/map.component';

const routes: Routes = [
  { path: '', component: IncidentListComponent },
  { path: 'incident/:id', component: IncidentDetailsComponent },
  { path: 'map', component: MapComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
