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
    public IActionResult Add(Book book)
    {
        return View();
    }
}