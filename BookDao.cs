using System;
using System.Collections.Generic;
using System.Text;

namespace DaoDB
{
    class BookDao : IDao<Book>
    {
        private List<Book> listOfBooks;
        public BookDao()
        {
            this.listOfBooks = new List<Book>();
        }
        public void Delete(Book obj)
        {
            listOfBooks.Remove(obj);
        }

        public Book Get(long id)
        {
            return listOfBooks.Find(book => book.Id == id);
        }

        public IList<Book> GetAll()
        {
            return listOfBooks;
        }

        public void Save(Book obj)
        {
            listOfBooks.Add(obj);
        }

        public void Update(Book old, Book actual)
        {
            listOfBooks[listOfBooks.FindIndex(book => book.Equals(old))] = actual;
        }
    }
}
