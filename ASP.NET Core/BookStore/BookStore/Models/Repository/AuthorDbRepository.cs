using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class AuthorDbRepository : IBookStoreRepository<Author>
    {
        BookStoreDbcontext _context;
        public AuthorDbRepository(BookStoreDbcontext context)
        {


            _context = context;

        }
        public void Add(Author entity)
        {

            _context.Authors.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Find(id);
            _context.Authors.Remove(book);
            _context.SaveChanges();
        }

        public Author Find(int id)
        {

            var book = _context.Authors.SingleOrDefault(m => m.Id == id);
            return book;

        }

        public IList<Author> List()
        {


            return _context.Authors.ToList();
        }

        public List<Author> Search(string term)
        {
            return _context.Authors.Where(a => a.FullName.Contains(term)).ToList();
        }

        public void Update(int id, Author entity)
        {
            _context.Update(entity);
            _context.SaveChanges();


        }
    }
}
