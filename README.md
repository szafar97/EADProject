# Enterprise Application Development - Assignment 04
A simple proeject in ASP.NET MVC.

Project Name: **Books Catalogue**

## Minimum Requirements to run the application
* Microsoft Visual Studio 2013 or higher
* .NET Framework 4.5 or higher
* Internet Information Services (IIS Express or IIS) (It comes with Visual Studio 2010 or higher)
* A Web Browser (Firefox, Chrome, Opera, Microsoft Edge, etc)

## Description of the Web Application
It is a simple web applicated oh books. All the ffeatures are listed below:
* Index Page - It shows drop-down list of different categories of books, select any and press the "View Books" to be forwarded to Books Catalogue View.
  * The category list is fetched from the database based on the currently existing books in the database.
  * "All Books" option will list all the books of all the categories existing in the database.
  
* View Books Page - It shows all the books of a specific category which was selected on the *Index* page or all books of all categories if you select "All Books" option on the *Index page*.
  * Shows title, description, author, and category of books.
  * It also shows two buttons at the end of each row to *Edit* or Delete* a specific book.
  
* Add Book page - A form will appear containing fields of Book Title, Book Author, Book Description and Book Category. Fill it to add a new book in the database.
  * You can choose an existing category or add a new one.
  
* Edit Book page - A similar form like *Add Book page* will appear but the fields will be already filled with the existing data.
  * You can just click the *Submit* button without changing anything if you changed your mind and don't want to edit any details of the book anymore.
  * Or you can change one (or multiple) attributes of the book and click Submit to reflect the changes in the database as well as on the *View Books page*.
  
* Delete Book - It doesn't have any view, if you click the *Delete* button on the "View Books" page, the book will be removed instantly from the database and the page will be refreshed and show the remaining books.

## How to Run the Application
1. Download/Clone the project from [here](https://github.com/szafar97/EADProject).
2. Run the *EAD_Project.sln* file in Visual Studio 2013 (or higher).
3. Click the browser name in toolbar (or press F5) to run the web application.
