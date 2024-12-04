using System.ComponentModel.DataAnnotations;

namespace W9_MvcProject.Models;

public class BookDetailsViewModel : Book
{
    [Display(Name = "Book Title")]
    [Required(ErrorMessage = "Title is required")]
    [MaxLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
    public string Title { get; set; } = string.Empty;
    
    [Display(Name = "Author")]
    [Required(ErrorMessage = "Author is required")]
    public int? AuthorId { get; set; }
    
    [Display(Name = "Genre")]
    [Required(ErrorMessage = "Genre is required")]
    public string Genre { get; set; } = string.Empty;
    
    [Display(Name = "Publish Date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Publish Date is required")]
    [Range(typeof(DateTime), "1/1/1800", "1/1/2100", 
        ErrorMessage = "Publish Date must be between 01.01.1800 and 01.01.2100")]
    public DateTime? PublishDate { get; set; }
    
    [Display(Name = "ISBN")]
    [Required(ErrorMessage = "ISBN is required")]
    [Length(17, 17, ErrorMessage = "ISBN must be 17 characters with hyphens")]
    public string Isbn { get; set; } = string.Empty;
    
    [Display(Name = "Copies Available")]
    [Required(ErrorMessage = "The number of available copies is required")]
    [Range(0, 10, ErrorMessage = "The number of available copies must be between 0 and 10")]
    public int? CopiesAvailable { get; set; }
}