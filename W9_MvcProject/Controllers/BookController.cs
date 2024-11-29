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
}