import {Component, Input, OnInit} from '@angular/core';
import {Book, BookId} from '../../models/book';
import {BooksService} from '../books.service';

@Component({
  selector: 'app-book-cover',
  templateUrl: './book-cover.component.html',
  styleUrls: ['./book-cover.component.css']
})
export class BookCoverComponent {

  @Input()
  book: Book;

  constructor(private bs: BooksService<Book>) {}

  removeBook() {
    this.bs.remove(this.book.isbn);
  }

  has(): boolean {
    return this.bs.has(this.book.isbn);
  }
}
