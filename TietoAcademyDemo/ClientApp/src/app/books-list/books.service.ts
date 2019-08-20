import { Injectable } from '@angular/core';
import {Book, BookId} from '../models/book';
import {BehaviorSubject, Observable} from 'rxjs';
import {environment} from '../../environments/environment';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BooksService<T extends Book> {

  private items: T[] = [];
  private readonly apiBase = environment.booksApiUrl;
  private items$ = new BehaviorSubject<T[]>([]);

  constructor(private http: HttpClient) {
    this.http.get<T[]>(this.apiBase)
      .subscribe(items => {
        this.items = items;
        this.items$.next(this.items);
      });
  }

  add(item: T): void {
    this.items.push(item);
    this.http.post(this.apiBase, item)
      .subscribe(
        () => {},
        () => {
          this.items = this.items.filter(({id}) => item.id !== id);
          this.items$.next(this.items);
        }
      );
  }

  remove(isbn: string): void {
    const bookmark = this.items.find(item => item.isbn === isbn);
    const bookmarkIndex = this.items.findIndex(idx => idx.isbn === bookmark.isbn);

    this.items = this.items.filter(item => item.isbn !== isbn);

    this.http.delete(`${this.apiBase}/${isbn}`)
      .subscribe(
        () => {
          this.items$.next(this.items);
        },
        () => {
          this.items.splice(bookmarkIndex, 0, bookmark);
          this.items$.next(this.items);
        }
      );
  }

  getAll(): Observable<T[]> {
    return this.items$.asObservable();
  }

  has(isbn: string): boolean {
    return this.items.some(item => item.isbn === isbn);
  }
}
