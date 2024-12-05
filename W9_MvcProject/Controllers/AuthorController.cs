using Microsoft.AspNetCore.Mvc;
using W9_MvcProject.Models;

namespace W9_MvcProject.Controllers;

public class AuthorController : Controller
{
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(AddAuthorViewModel model)
    {
        if (ModelState.IsValid)
        {
            Data.Authors.Add(new Author
                {
                    Id = Data.Authors.Max(a => a.Id) + 1,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                }
            );
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }
    
    public IActionResult List()
    {
        return View();
    }
    
    public IActionResult Edit(int id)
    {
        var author = Data.Authors.FirstOrDefault(a => a.Id == id);
        
        if (author == null)
        {
            return NotFound();
        }
        
        var viewModel = new AuthorDetailsViewModel
        {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName,
            DateOfBirth = author.DateOfBirth
        };
        
        return View(viewModel);
    }
    
    [HttpPost]
    public IActionResult Edit(AuthorDetailsViewModel author)
    {
        if (ModelState.IsValid)
        {
            var existingAuthor = Data.Authors.FirstOrDefault(a => a.Id == author.Id);
            
            if (existingAuthor != null)
            {
                existingAuthor.FirstName = author.FirstName;
                existingAuthor.LastName = author.LastName;
                existingAuthor.DateOfBirth = author.DateOfBirth.Value;
            }
            
            return RedirectToAction("List", "Author");
        }
        
        return View();
    }
    
    public IActionResult Details(int id)
    {
        var author = Data.Authors.FirstOrDefault(a => a.Id == id);
        
        if (author == null)
        {
            return NotFound();
        }
        
        var viewModel = new AuthorDetailsViewModel
        {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName,
            DateOfBirth = author.DateOfBirth
        };
        
        return View(viewModel);
    }
    
    public IActionResult DeleteConfirm(int id)
    {
        var author = Data.Authors.FirstOrDefault(a => a.Id == id);
        
        if (author == null)
        {
            return NotFound();
        }
        
        var viewModel = new AuthorDetailsViewModel
        {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName,
            DateOfBirth = author.DateOfBirth
        };
        
        return View(viewModel);
    }
    
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var author = Data.Authors.FirstOrDefault(a => a.Id == id);
        
        if (author != null)
        {   
            var books = Data.Books.Where(b => b.AuthorId == author.Id).ToList();
            
            foreach (var book in books)
            {
                Data.Books.Remove(book);
            }
            Data.Authors.Remove(author);
        }
        
        return RedirectToAction("List", "Author");
    }
}