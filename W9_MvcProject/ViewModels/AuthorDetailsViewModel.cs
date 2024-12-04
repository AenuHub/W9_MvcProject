using System.ComponentModel.DataAnnotations;

namespace W9_MvcProject.Models;

public class AuthorDetailsViewModel : Author
{
    [Display(Name = "Author First Name")]
    [Required(ErrorMessage = "First Name is required")]
    [MaxLength(25, ErrorMessage = "First Name cannot be longer than 25 characters")]
    public string FirstName { get; set; } = string.Empty;
    
    [Display(Name = "Author Last Name")]
    [Required(ErrorMessage = "Last Name is required")]
    [MaxLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
    public string LastName { get; set; } = string.Empty;
    
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Date of Birth is required")]
    [Range(typeof(DateTime), "1/1/1800", "1/1/2010", 
        ErrorMessage = "Date of Birth must be between 01.01.1800 and 01.01.2010")]
    public DateTime? DateOfBirth { get; set; }
    
    public string GetDateString() => DateOfBirth?.ToString("dd-MM-yyyy");
    
    public List<Book> GetBooks() => Data.Books.Where(b => b.AuthorId == Id).ToList();
}