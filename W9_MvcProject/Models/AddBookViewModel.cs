using System.ComponentModel.DataAnnotations;

namespace W9_MvcProject.Models;

public class AddBookViewModel
{   
    [Display(Name = "Book Title")]
    public string Title { get; set; } = string.Empty;
    
    [Display(Name = "Author")]
    public int AuthorId { get; set; }
    
    [Display(Name = "Genre")]
    public string Genre { get; set; } = string.Empty;
    
    [Display(Name = "Publish Date")]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }
    
    [Display(Name = "ISBN")]
    public string Isbn { get; set; } = string.Empty;
    
    [Display(Name = "Copies Available")]
    public int CopiesAvailable { get; set; }
}