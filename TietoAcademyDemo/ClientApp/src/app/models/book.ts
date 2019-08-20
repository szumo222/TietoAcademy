export type BookId = string | number;

export interface Book {
  id?: BookId;
  authors: string;
  publisher: string;
  title: string;
  isbn: string;
  publishDate: Date;
  publishPlace: string;
  numberOfPages: string;
  subject: string;
  coverUrl?: string;
}
