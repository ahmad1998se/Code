using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book {Id = 1, Title = "Ahmad", Description = "No Description",Author = new Author{Id = 2},ImageUrl="2.png" },
                new Book {Id = 2, Title = "Anas", Description = "Nothing",Author = new Author(),ImageUrl="3.png"},
                new Book {Id = 3, Title = "Eman", Description = "Empty",Author = new Author(),ImageUrl="download.png"}
            };



        }

        public void Add(Book entity)
        {
            entity.Id = books.Max(m => m.Id) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {

            var book = books.SingleOrDefault(m => m.Id == id);
            return book;

        }

        public IList<Book> List()
        {


            return books;
        }

        public List<Book> Search(string term)
        {
            return books.Where(a => a.Title.Contains(term)).ToList();
        }

        public void Update(int id ,Book entity)
        {
            var book = Find(id);
            book.Title = entity.Title;
            book.Description = entity.Description;
            book.Author = entity.Author;
            book.ImageUrl = entity.ImageUrl;


        }
    }
}
