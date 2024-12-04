using Microsoft.AspNetCore.Mvc.Rendering;

namespace W9_MvcProject.Models;

public static class Data
{
    public static List<Author> Authors = new()
    {
        // author list of 20 authors randomly generated using mockaroo for testing purposes
        new Author { Id = 1, FirstName = "John", LastName = "Smith", DateOfBirth = DateTime.Parse("01/02/1970") },
        new Author { Id = 2, FirstName = "Emily", LastName = "Johnson", DateOfBirth = DateTime.Parse("14/04/1985") },
        new Author { Id = 3, FirstName = "Michael", LastName = "Williams", DateOfBirth = DateTime.Parse("23/11/1990") },
        new Author { Id = 4, FirstName = "Sarah", LastName = "Brown", DateOfBirth = DateTime.Parse("07/03/1982") },
        new Author { Id = 5, FirstName = "David", LastName = "Jones", DateOfBirth = DateTime.Parse("19/06/1965") },
        new Author { Id = 6, FirstName = "Sophia", LastName = "Garcia", DateOfBirth = DateTime.Parse("15/08/1993") },
        new Author { Id = 7, FirstName = "Daniel", LastName = "Martinez", DateOfBirth = DateTime.Parse("28/09/1978") },
        new Author { Id = 8, FirstName = "Olivia", LastName = "Hernandez", DateOfBirth = DateTime.Parse("12/01/1980") },
        new Author { Id = 9, FirstName = "James", LastName = "Lopez", DateOfBirth = DateTime.Parse("17/10/1992") },
        new Author { Id = 10, FirstName = "Isabella", LastName = "Gonzalez", DateOfBirth = DateTime.Parse("03/05/1988") },
        new Author { Id = 11, FirstName = "Ethan", LastName = "Wilson", DateOfBirth = DateTime.Parse("26/12/1984") },
        new Author { Id = 12, FirstName = "Mia", LastName = "Anderson", DateOfBirth = DateTime.Parse("09/09/1997") },
        new Author { Id = 13, FirstName = "Liam", LastName = "Thomas", DateOfBirth = DateTime.Parse("02/04/1974") },
        new Author { Id = 14, FirstName = "Ava", LastName = "Taylor", DateOfBirth = DateTime.Parse("21/07/1986") },
        new Author { Id = 15, FirstName = "Benjamin", LastName = "Moore", DateOfBirth = DateTime.Parse("11/11/1968") },
        new Author { Id = 16, FirstName = "Charlotte", LastName = "Jackson", DateOfBirth = DateTime.Parse("06/02/1990") },
        new Author { Id = 17, FirstName = "Lucas", LastName = "White", DateOfBirth = DateTime.Parse("20/05/1981") },
        new Author { Id = 18, FirstName = "Amelia", LastName = "Clark", DateOfBirth = DateTime.Parse("22/08/1994") },
        new Author { Id = 19, FirstName = "Oliver", LastName = "Lewis", DateOfBirth = DateTime.Parse("10/12/1980") },
        new Author { Id = 20, FirstName = "Harper", LastName = "Roberts", DateOfBirth = DateTime.Parse("30/09/1995") }
    };
    
    // book list of 50 books randomly generated using mockaroo for testing purposes
    public static List<Book> Books = new()
    {
        new Book { Id = 1, Title = "Shadows of the Sun", AuthorId = 3, Genre = "Fiction", PublishDate = DateTime.Parse("15/08/1956"), Isbn = "978-3-16-148410-0", CopiesAvailable = 5 },
        new Book { Id = 2, Title = "The Forgotten Realm", AuthorId = 12, Genre = "Fantasy", PublishDate = DateTime.Parse("11/06/1998"), Isbn = "978-1-84-149965-7", CopiesAvailable = 7 },
        new Book { Id = 3, Title = "A Symphony of Echoes", AuthorId = 15, Genre = "Historical", PublishDate = DateTime.Parse("29/03/2010"), Isbn = "978-0-06-211485-1", CopiesAvailable = 4 },
        new Book { Id = 4, Title = "Beneath the Crescent Moon", AuthorId = 9, Genre = "Science Fiction", PublishDate = DateTime.Parse("10/10/2005"), Isbn = "978-1-43-919919-3", CopiesAvailable = 10 },
        new Book { Id = 5, Title = "Secrets of the Deep", AuthorId = 8, Genre = "Adventure", PublishDate = DateTime.Parse("25/05/2000"), Isbn = "978-0-07-162623-3", CopiesAvailable = 3 },
        new Book { Id = 6, Title = "Dancing on Air", AuthorId = 18, Genre = "Romance", PublishDate = DateTime.Parse("04/07/2009"), Isbn = "978-0-14-102678-8", CopiesAvailable = 8 },
        new Book { Id = 7, Title = "The Clockwork Tales", AuthorId = 2, Genre = "Mystery", PublishDate = DateTime.Parse("13/09/2003"), Isbn = "978-0-670-03337-6", CopiesAvailable = 6 },
        new Book { Id = 8, Title = "Echoes in the Storm", AuthorId = 14, Genre = "Drama", PublishDate = DateTime.Parse("01/11/2012"), Isbn = "978-1-63-216814-6", CopiesAvailable = 2 },
        new Book { Id = 9, Title = "Whispering Shadows", AuthorId = 5, Genre = "Thriller", PublishDate = DateTime.Parse("08/08/2001"), Isbn = "978-1-42-675653-5", CopiesAvailable = 9 },
        new Book { Id = 10, Title = "Threads of Destiny", AuthorId = 10, Genre = "Fiction", PublishDate = DateTime.Parse("16/02/1999"), Isbn = "978-1-40-122669-2", CopiesAvailable = 4 },
        new Book { Id = 11, Title = "The Last Sunset", AuthorId = 1, Genre = "Fantasy", PublishDate = DateTime.Parse("20/03/2011"), Isbn = "978-1-93-402248-1", CopiesAvailable = 5 },
        new Book { Id = 12, Title = "The Hidden Truth", AuthorId = 6, Genre = "Mystery", PublishDate = DateTime.Parse("12/07/2007"), Isbn = "978-0-14-102777-7", CopiesAvailable = 7 },
        new Book { Id = 13, Title = "City of Dreams", AuthorId = 19, Genre = "Romance", PublishDate = DateTime.Parse("24/01/2015"), Isbn = "978-1-40-135897-2", CopiesAvailable = 6 },
        new Book { Id = 14, Title = "Waves of Time", AuthorId = 4, Genre = "Science Fiction", PublishDate = DateTime.Parse("17/08/2010"), Isbn = "978-1-67-405232-3", CopiesAvailable = 8 },
        new Book { Id = 15, Title = "Dark Reflections", AuthorId = 13, Genre = "Thriller", PublishDate = DateTime.Parse("03/09/2003"), Isbn = "978-0-14-111234-7", CopiesAvailable = 4 },
        new Book { Id = 16, Title = "Lullaby for the Broken", AuthorId = 3, Genre = "Drama", PublishDate = DateTime.Parse("21/11/2010"), Isbn = "978-1-67-112233-4", CopiesAvailable = 3 },
        new Book { Id = 17, Title = "Echoes of the Past", AuthorId = 11, Genre = "Historical", PublishDate = DateTime.Parse("25/06/1995"), Isbn = "978-0-14-135663-0", CopiesAvailable = 5 },
        new Book { Id = 18, Title = "Wings of Freedom", AuthorId = 2, Genre = "Adventure", PublishDate = DateTime.Parse("10/09/2014"), Isbn = "978-1-40-212348-4", CopiesAvailable = 9 },
        new Book { Id = 19, Title = "The Silver Dream", AuthorId = 7, Genre = "Fantasy", PublishDate = DateTime.Parse("04/02/2009"), Isbn = "978-0-15-195778-9", CopiesAvailable = 6 },
        new Book { Id = 20, Title = "Blood of the Heart", AuthorId = 20, Genre = "Romance", PublishDate = DateTime.Parse("17/05/2017"), Isbn = "978-1-62-111234-8", CopiesAvailable = 7 },
        new Book { Id = 21, Title = "Rays of Destiny", AuthorId = 12, Genre = "Mystery", PublishDate = DateTime.Parse("08/10/2012"), Isbn = "978-1-64-223213-5", CopiesAvailable = 8 },
        new Book { Id = 22, Title = "Beneath the Ocean Sky", AuthorId = 18, Genre = "Science Fiction", PublishDate = DateTime.Parse("22/07/2006"), Isbn = "978-0-14-176753-3", CopiesAvailable = 5 },
        new Book { Id = 23, Title = "Unbroken Path", AuthorId = 8, Genre = "Adventure", PublishDate = DateTime.Parse("19/04/2008"), Isbn = "978-1-14-312249-0", CopiesAvailable = 7 },
        new Book { Id = 24, Title = "The Forbidden Zone", AuthorId = 9, Genre = "Fiction", PublishDate = DateTime.Parse("03/01/2012"), Isbn = "978-1-16-314589-0", CopiesAvailable = 3 },
        new Book { Id = 25, Title = "Bitter Winds", AuthorId = 4, Genre = "Thriller", PublishDate = DateTime.Parse("10/10/2015"), Isbn = "978-1-10-186415-3", CopiesAvailable = 6 },
        new Book { Id = 26, Title = "Dreams in the Night", AuthorId = 5, Genre = "Drama", PublishDate = DateTime.Parse("15/12/2011"), Isbn = "978-1-45-102934-1", CopiesAvailable = 8 },
        new Book { Id = 27, Title = "The Last Keeper", AuthorId = 20, Genre = "Historical", PublishDate = DateTime.Parse("06/02/2013"), Isbn = "978-1-13-190121-2", CopiesAvailable = 7 },
        new Book { Id = 28, Title = "Rogue Waves", AuthorId = 16, Genre = "Fantasy", PublishDate = DateTime.Parse("17/09/2007"), Isbn = "978-1-92-314112-3", CopiesAvailable = 4 },
        new Book { Id = 29, Title = "End of the Line", AuthorId = 13, Genre = "Science Fiction", PublishDate = DateTime.Parse("09/11/2016"), Isbn = "978-1-56-190321-0", CopiesAvailable = 9 },
        new Book { Id = 30, Title = "Fires of Dawn", AuthorId = 2, Genre = "Adventure", PublishDate = DateTime.Parse("01/03/2009"), Isbn = "978-1-90-445922-4", CopiesAvailable = 8 },
        new Book { Id = 31, Title = "The Silent Watcher", AuthorId = 3, Genre = "Mystery", PublishDate = DateTime.Parse("18/05/2014"), Isbn = "978-1-48-624330-0", CopiesAvailable = 5 },
        new Book { Id = 32, Title = "Whispers on the Wind", AuthorId = 19, Genre = "Romance", PublishDate = DateTime.Parse("22/09/2015"), Isbn = "978-0-19-446190-8", CopiesAvailable = 7 },
        new Book { Id = 33, Title = "City of Secrets", AuthorId = 16, Genre = "Thriller", PublishDate = DateTime.Parse("03/04/2007"), Isbn = "978-1-23-541987-0", CopiesAvailable = 6 },
        new Book { Id = 34, Title = "Vows in the Dark", AuthorId = 10, Genre = "Drama", PublishDate = DateTime.Parse("10/10/2001"), Isbn = "978-1-07-331129-3", CopiesAvailable = 5 },
        new Book { Id = 35, Title = "In the Heart of the Storm", AuthorId = 14, Genre = "Historical", PublishDate = DateTime.Parse("14/03/2002"), Isbn = "978-1-22-555622-1", CopiesAvailable = 7 },
        new Book { Id = 36, Title = "The Veil of Lies", AuthorId = 18, Genre = "Fantasy", PublishDate = DateTime.Parse("28/07/2011"), Isbn = "978-1-99-428510-6", CopiesAvailable = 3 },
        new Book { Id = 37, Title = "Across the Divide", AuthorId = 7, Genre = "Science Fiction", PublishDate = DateTime.Parse("13/12/2009"), Isbn = "978-0-25-617093-8", CopiesAvailable = 5 },
        new Book { Id = 38, Title = "Tears of the Fallen", AuthorId = 17, Genre = "Adventure", PublishDate = DateTime.Parse("22/01/2013"), Isbn = "978-1-41-583017-3", CopiesAvailable = 4 },
        new Book { Id = 39, Title = "The Mirror of Souls", AuthorId = 12, Genre = "Thriller", PublishDate = DateTime.Parse("30/06/2010"), Isbn = "978-0-44-413211-7", CopiesAvailable = 7 },
        new Book { Id = 40, Title = "Twilight's Embrace", AuthorId = 15, Genre = "Romance", PublishDate = DateTime.Parse("07/03/2014"), Isbn = "978-1-62-879233-4", CopiesAvailable = 9 },
        new Book { Id = 41, Title = "End of the Horizon", AuthorId = 6, Genre = "Mystery", PublishDate = DateTime.Parse("04/05/2016"), Isbn = "978-1-59-537065-9", CopiesAvailable = 3 },
        new Book { Id = 42, Title = "The Forbidden Truth", AuthorId = 1, Genre = "Science Fiction", PublishDate = DateTime.Parse("11/11/2008"), Isbn = "978-1-42-649759-7", CopiesAvailable = 6 },
        new Book { Id = 43, Title = "Whispers in the Dark", AuthorId = 8, Genre = "Fiction", PublishDate = DateTime.Parse("22/03/2012"), Isbn = "978-0-75-512898-0", CopiesAvailable = 7 },
        new Book { Id = 44, Title = "In the Silence of Night", AuthorId = 20, Genre = "Drama", PublishDate = DateTime.Parse("05/07/2013"), Isbn = "978-1-23-545899-2", CopiesAvailable = 5 },
        new Book { Id = 45, Title = "The Last Song", AuthorId = 10, Genre = "Romance", PublishDate = DateTime.Parse("19/09/2014"), Isbn = "978-0-15-206758-9", CopiesAvailable = 6 },
        new Book { Id = 46, Title = "The Great Beyond", AuthorId = 4, Genre = "Adventure", PublishDate = DateTime.Parse("01/01/2004"), Isbn = "978-0-19-615417-3", CopiesAvailable = 3 },
        new Book { Id = 47, Title = "Rising from the Ashes", AuthorId = 17, Genre = "Thriller", PublishDate = DateTime.Parse("21/04/2016"), Isbn = "978-0-14-019853-1", CopiesAvailable = 6 },
        new Book { Id = 48, Title = "Into the Depths", AuthorId = 2, Genre = "Historical", PublishDate = DateTime.Parse("10/08/2005"), Isbn = "978-1-13-798925-0", CopiesAvailable = 5 },
        new Book { Id = 49, Title = "Echoes of a Distant Past", AuthorId = 13, Genre = "Fantasy", PublishDate = DateTime.Parse("17/05/2008"), Isbn = "978-0-14-119234-4", CopiesAvailable = 8 },
        new Book { Id = 50, Title = "Across the Universe", AuthorId = 14, Genre = "Science Fiction", PublishDate = DateTime.Parse("06/06/2015"), Isbn = "978-1-44-222900-1", CopiesAvailable = 7 }
    };
    
    public static List<SelectListItem> GetAuthors() => Authors
        .Select(a => new SelectListItem(a.GetFullName(), a.Id.ToString())).ToList();
}