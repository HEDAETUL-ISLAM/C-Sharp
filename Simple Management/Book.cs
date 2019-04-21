using System;

namespace Simple_Management
{
    public class Book
    {
        private string  bookName;
        private string bookAuthor;
        private  string bookId;
        private string bookType;
        private int bookCopy;

        public string GetBookName(){
            return bookName;
        }
        public string GetBookAurthor(){
            return bookAuthor;
        }
        public string GetBookId(){
            return bookId;
        }
        public string GetBookType(){
            return bookType;
        }
        public int GetBookCopy(){
            return bookCopy;
        }
        public Book(){

        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy){
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void ShowInfo(){
            System.Console.WriteLine("Book Name: "+GetBookName()+" ,"+"Book Author: "+GetBookAurthor()+" ,"+"Book Id: "+GetBookId()+" ,"+"Book Type: "+GetBookType()+" ,"+"Book Copy: "+GetBookCopy()+" ");
        }
        public void AddBookCopy(int newBook){
            this.bookCopy += newBook;
        }
    }
}
