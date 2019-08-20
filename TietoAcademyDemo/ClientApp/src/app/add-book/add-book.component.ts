import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import {Book} from '../models/book';
import {BooksService} from '../books-list/books.service';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  bookModel: Book = {
    title: '',
    authors: '',
    publisher: '',
    isbn: '',
    publishDate: new Date(),
    publishPlace: '',
    numberOfPages: '',
    subject: ''
  };

  constructor(private bs: BooksService<Book>,
              private location: Location) {}

  ngOnInit() {
  }

  async newBook() {
    const response = await this.bs.add(this.bookModel);
    this.location.back();
  }

  cancel() {
    this.location.back();
  }

  has(): boolean {
    return this.bs.has(this.bookModel.isbn);
  }

}
