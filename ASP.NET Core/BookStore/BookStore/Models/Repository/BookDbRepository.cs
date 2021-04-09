using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class BookDbRepository : IBookStoreRepository<Book>
    {
        BookStoreDbcontext _context;

        public BookDbRepository(BookStoreDbcontext context)
        {
            _context = context;

        }

        public void Add(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book Find(int id)
        {

            var book = _context.Books.Include(a => a.Author).SingleOrDefault(m => m.Id == id);
            return book;

        }

        public IList<Book> List()
        {


            return _context.Books.Include(a=>a.Author).ToList();
        }

        public void Update(int id, Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();

        }


        public List<Book> Search(string term)
        {
            var result = _context.Books.Include(m => m.Author).Where(b => b.Title.Contains(term)
            || b.Description.Contains(term)
            || b.Author.FullName.Contains(term)).ToList();


            return result;
        }
    }
}
