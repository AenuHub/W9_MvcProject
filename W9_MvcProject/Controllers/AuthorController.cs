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
}