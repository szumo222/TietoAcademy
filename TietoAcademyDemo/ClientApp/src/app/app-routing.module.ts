import { NgModule } from '@angular/core';
import {RouterModule, Routes} from "@angular/router";
import {HomeComponent} from "./home/home.component";
import {BooksListComponent} from "./books-list/books-list.component";
import {AddBookComponent} from "./add-book/add-book.component";

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'books-list/add-book', component: AddBookComponent, pathMatch: 'full' },
  { path: 'books-list', component: BooksListComponent, pathMatch: 'full'}
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
