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
    public IActionResult Add(AddBookViewModel model)
    {
        if (ModelState.IsValid)
        {
            Data.Books.Add( new Book
                    {
                        Id = Data.Books.Count + 1,
                        Title = model.Title,
                        AuthorId = model.AuthorId.Value,
                        Genre = model.Genre,
                        PublishDate = model.PublishDate.Value,
                        Isbn = model.Isbn,
                        CopiesAvailable = model.CopiesAvailable.Value
                    }
                );
        }
        
        return View(model);
    }
}