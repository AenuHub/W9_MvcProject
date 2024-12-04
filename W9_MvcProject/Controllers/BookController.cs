using Microsoft.AspNetCore.Mvc;
using W9_MvcProject.Models;

namespace W9_MvcProject.Controllers;

public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(AddBookViewModel book)
    {
        if (ModelState.IsValid)
        {
            Data.Books.Add( new Book
                    {
                        Id = Data.Books.Max(b => b.Id) + 1,
                        Title = book.Title,
                        AuthorId = book.AuthorId.Value,
                        Genre = book.Genre,
                        PublishDate = book.PublishDate.Value,
                        Isbn = book.Isbn,
                        CopiesAvailable = book.CopiesAvailable.Value
                    }
                );
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult Edit(int id)
    {
        var book = Data.Books.FirstOrDefault(b => b.Id == id);
        
        if (book == null)
        {
            return NotFound();
        }
        
        var viewModel = new BookDetailsViewModel
        {
            Id = book.Id,
            Title = book.Title,
            AuthorId = book.AuthorId,
            Genre = book.Genre,
            PublishDate = book.PublishDate,
            Isbn = book.Isbn,
            CopiesAvailable = book.CopiesAvailable
        };
        
        return View(viewModel);
    }
    
    [HttpPost]
    public IActionResult Edit(BookDetailsViewModel book)
    {
        if (ModelState.IsValid)
        {
            var existingBook = Data.Books.FirstOrDefault(b => b.Id == book.Id);
            
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.AuthorId = book.AuthorId.Value;
                existingBook.Genre = book.Genre;
                existingBook.PublishDate = book.PublishDate.Value;
                existingBook.Isbn = book.Isbn;
                existingBook.CopiesAvailable = book.CopiesAvailable.Value;
                
                return RedirectToAction("Index", "Home");
            }
        }
        
        return View();
    }
}