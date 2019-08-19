import { NgModule } from '@angular/core';
import {RouterModule, Routes} from "@angular/router";
import {HomeComponent} from "./home/home.component";

const routes: Routes = [
  { path: '', component: HomeComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {useHash: false})
  ],
  providers: [],
  declarations: [],
  exports: [RouterModule],
})
export class AppRoutingModule { }
