
## W9_MvcProject - Patika+ Back-End Bootcamp Week 9 Project

**Project Name**: Book Repository / Library Management System

**Project Type**: ASP.NET Core MVC Application  

## About the Project

This project is a comprehensive **Library Management System** designed to manage the book and author operations of a library. It is built with modern **MVC (Model-View-Controller)** architecture and adheres to the principles of **Object-Oriented Programming (OOP)**.  

**Key Features**:  
- Book and author management  
- Detailed models and ViewModel usage  
- User-friendly interface and form-based interactions  
- Static file management and customized routing configuration  

---

## Project Structure

The project is structured as follows:

### Models  

#### **_Book Model:_**  
| Field             | Type        | Description                              |  
|-------------------|-------------|------------------------------------------|  
| `Id`              | `int`       | Unique identifier                        |  
| `Title`           | `string`    | Book title                               |  
| `AuthorId`        | `int`       | Author ID (reference to Author model)    |  
| `Genre`           | `string`    | Book genre                               |  
| `PublishDate`     | `DateTime`  | Publication date                         |  
| `Isbn`            | `string`    | ISBN number                              |  
| `CopiesAvailable` | `int`       | Number of copies available               |  

#### **_Author Model:_**  
| Field          | Type        | Description              |  
|----------------|-------------|--------------------------|  
| `Id`           | `int`       | Unique identifier        |  
| `FirstName`    | `string`    | Author's first name      |  
| `LastName`     | `string`    | Author's last name       |  
| `DateOfBirth`  | `DateTime`  | Author's date of birth   |  

---

### ViewModels  

- **AddAuthorViewModel**: To add new authors.  
- **AddBookViewModel**: To add new books.
- **BookDetailsViewModel**: To display book details and list books on pages.  
- **AuthorDetailsViewModel**: To display author details and list authors on pages.  

---

### Controllers  

#### **_BookController:_**  
Manages operations related to books:  
- `List`: Displays a list of books.  
- `Details`: Displays details of a selected book.  
- `Create`: Provides a form to add a new book.  
- `Edit`: Provides a form to edit an existing book.  
- `Delete`: Displays a confirmation page to delete a book.  

#### **_AuthorController:_**  
Manages operations related to authors:  
- `List`: Displays a list of authors.  
- `Details`: Displays details of a selected author.  
- `Create`: Provides a form to add a new author.  
- `Edit`: Provides a form to edit an existing author.  
- `Delete`: Displays a confirmation page to delete an author.  

---

### Views  

#### **_Book Views_**  
- `List`: Page displaying the list of books with edit, details and delete button.  
- `Details`: Page showing book details with edit and cancel button.  
- `Create`: Form page to add a new book.  
- `Edit`: Form page to edit existing books.
- `DeleteConfirm`: Confirmation page to delete a book.

#### **_Author Views_**  
- `List`: Page displaying the list of authors with edit, details and delete button.  
- `Details`: Page showing author details with edit and cancel button.  
- `Create`: Form page to add a new author.  
- `Edit`: Form page to edit existing authors.
- `DeleteConfirm`: Confirmation page to delete an author and his/her books.

---

### Layouts  

- Included `Home` and `About` pages.  
- Used `PartialView` for dynamic layouts.  
- Included a `_FooterPartial` partial view at the bottom of every page stating ownership rights.  

---

## Running the Project  

1. **Clone and Configure the Project**  
   ```bash  
   git clone https://github.com/AenuHub/W9_MvcProject.git  
   cd W9_MvcProject  
   ```  

2. **Install Dependencies**  
   - Ensure .NET SDK is installed.

3. **Run the Project**  
   ```bash  
   dotnet run  
   ```  

---
