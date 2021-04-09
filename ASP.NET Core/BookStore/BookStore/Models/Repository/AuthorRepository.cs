using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        List<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author {Id = 1, FullName = "Ahmad Almahameed"},
                new Author {Id = 2, FullName = "Anas Almahameed"},
                new Author {Id = 3, FullName = "Eman Almahameed"}
            };



        }
        public void Add(Author entity)
        {
            entity.Id = authors.Max(m => m.Id) + 1;

            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            authors.Remove(book);
        }

        public Author Find(int id)
        {

            var book = authors.SingleOrDefault(m => m.Id == id);
            return book;

        }

        public IList<Author> List()
        {


            return authors;
        }

        public List<Author> Search(string term)
        {

            return authors.Where(a => a.FullName.Contains(term)).ToList();

        }

        public void Update(int id, Author entity)
        {
            var author = Find(id);
            author.FullName = entity.FullName;


        }
    }
}
