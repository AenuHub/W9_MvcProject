using System.ComponentModel.DataAnnotations;

namespace W9_MvcProject.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int AuthorId { get; set; }
    public string Genre { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public string Isbn { get; set; } = string.Empty;
    public int CopiesAvailable { get; set; }
}