using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Models.Repository;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Hosting;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookStoreRepository<Book> bookRepository;
        private readonly IBookStoreRepository<Author> authoRepository;
        private readonly IHostingEnvironment hosting;


        public BookController(IBookStoreRepository<Book> bookRepository,
            IBookStoreRepository<Author> authoRepository,
            IHostingEnvironment hosting)
        {
            this.bookRepository = bookRepository;
            this.authoRepository = authoRepository;
            this.hosting = hosting;



        }



        // GET: BookController
        public ActionResult Index()
        {
            var books = bookRepository.List();

            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {

            var book = bookRepository.Find(id);

            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {

            var model = new BookAuthorViewModel
            {
                Authors = FillSelectList()

            };

            return View(model);
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookAuthorViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    string fileName = UploadFile(model.File) ?? string.Empty;

                    if (model.AuthorId == -1)
                    {
                        ViewBag.Message = "Please Select An Author from list";

                        return View(GetAllAuthors());
                    }
                    var author = authoRepository.Find(model.AuthorId);
                    Book book = new Book()
                    {
                        Id = model.BookId,
                        Title = model.Title,
                        Description = model.Description,
                        Author = author,
                        ImageUrl = fileName

                    };
                    bookRepository.Add(book);

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return View();
                }

            }
            else
            {
                ModelState.AddModelError("", "There Is Error While Validate Model");
                return View(GetAllAuthors());
            }


        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = bookRepository.Find(id);
            var authorId = book.Author == null ? book.Author.Id = 0 : book.Author.Id;
            var viewModel = new BookAuthorViewModel
            {
                BookId = book.Id,
                Title = book.Title,
                Description = book.Description,
                AuthorId = authorId,
                Authors = authoRepository.List().ToList(),
                ImageUrl = book.ImageUrl

            };


            return View(viewModel);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookAuthorViewModel viewModel)
        {
            try
            {
                string fileName = UploadFile(viewModel.File, viewModel.ImageUrl);

                var author = authoRepository.Find(viewModel.AuthorId);
                Book book = new Book()
                {
                    Id = viewModel.BookId,
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                    Author = author,
                    ImageUrl = fileName


                };
                bookRepository.Update(viewModel.BookId, book);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = bookRepository.Find(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {

                bookRepository.Delete(id);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        BookAuthorViewModel GetAllAuthors()
        {

            var vmodel = new BookAuthorViewModel
            {
                Authors = FillSelectList()

            };
            return vmodel;

        }

        List<Author> FillSelectList()
        {
            var authors = authoRepository.List().ToList();
            authors.Insert(0, new Author { Id = -1, FullName = "---- Please Select An Author ----" });
            return authors;
        }

        string UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Uploads");
                string FullPath = Path.Combine(uploads, file.FileName);
                file.CopyTo(new FileStream(FullPath, FileMode.Create));
                return file.FileName;
            }
            return null;

        }
        string UploadFile(IFormFile file, string ImageUrl)
        {

            if (file != null)
            {
                string uploads = Path.Combine(hosting.WebRootPath, "Uploads");
                string newPath = Path.Combine(uploads, file.FileName);
                //Delete the Old File 
                string oldPath = Path.Combine(uploads, ImageUrl);
                if (oldPath != newPath)
                {
                    System.IO.File.Delete(oldPath);
                    //Save The New File
                    file.CopyTo(new FileStream(newPath, FileMode.Create));
                }
                return file.FileName;

            }

            return ImageUrl;

        }

        public ActionResult Search(string term)
        {
            var result = bookRepository.Search(term);
            return View("Index", result);
        
        }
    }
}
