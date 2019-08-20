import { Component } from '@angular/core';
import {Router} from '@angular/router';
import {BooksService} from './books.service';
import {Book, BookId} from '../models/book';
import {Observable} from 'rxjs';

@Component({
  selector: 'app-books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent {

  books$: Observable<Book[]>;


  constructor(private router: Router,
              private bs: BooksService<Book>) {
    this.books$ = this.bs.getAll();
  }
}
