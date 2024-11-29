using System.ComponentModel.DataAnnotations;

namespace W9_MvcProject.Models;

public class AddBookViewModel
{   
    [Display(Name = "Book Title")]
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = string.Empty;
    
    [Display(Name = "Author")]
    [Required(ErrorMessage = "Author is required")]
    public int AuthorId { get; set; }
    
    [Display(Name = "Genre")]
    [Required(ErrorMessage = "Genre is required")]
    public string Genre { get; set; } = string.Empty;
    
    [Display(Name = "Publish Date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Publish Date is required")]
    public DateTime PublishDate { get; set; }
    
    [Display(Name = "ISBN")]
    [Required(ErrorMessage = "ISBN is required")]
    public string Isbn { get; set; } = string.Empty;
    
    [Display(Name = "Copies Available")]
    [Required(ErrorMessage = "The number of available copies is required")]
    public int CopiesAvailable { get; set; }
}