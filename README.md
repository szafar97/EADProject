# Enterprise Application Development - Assignment 04
## Books Inventory System
A simple project in ASP.NET MVC.

Project Name: **Books Inventory System**

## Table of Contents
1. Description of the Web Application
2. Minimum Software Requirements
3. Minimum Hardware Requirements
4. How to Run the Application

### Description of the Web Application
It is a simple book inventory system. All features are listed below:
* Index Page - It shows drop-down list of different categories of books, select any and press the "View Books" button to be forwarded to Books Catalogue View.
  * The category list is fetched from the database based on the currently existing books in the database.
  * "All Books" option will list all the books of all the categories existing in the database.
  
* View Books Page - It shows all the books of a specific category which was selected on the *Index* page or all books of all categories if you select "All Books" option on the *Index page*.
  * Shows title, description, author, and category of books.
  * It also shows two buttons at the end of each row to *Edit* or Delete* a specific book.
  
* Add Book page - A form will appear containing fields of Book Title, Book Author, Book Description and Book Category. Fill it to add a new book in the inventory.
  * You can choose an existing category or add a new one.
  
* Edit Book page - A similar form like *Add Book page* will appear but the fields will already be filled with the existing data.
  * You can just click the *Submit* button without changing anything if you changed your mind and don't want to edit any details of the book anymore.
  * Or you can change one (or multiple) attributes of the book and click Submit to reflect the changes in the database/inventory as well as on the *View Books page*.
  
* Delete Book - It doesn't have any view, if you click the *Delete* button on the "View Books" page, that specific book will be removed instantly from the database/inventory and the page will be refreshed to show the remaining books.

### Minimum Software Requirements to run the application
* Microsoft Windows 8.1 or higher.
* [Microsoft Visual Studio 2013](www.visualstudio.com/en-us/products/visual-studio-community-vs) or higher
* .NET Framework 4.5 or higher
* Internet Information Services (IIS Express or IIS) (It comes with Visual Studio 2010 or higher)
* A Web Browser (Firefox, Chrome, Opera, Microsoft Edge, etc)

### Minimum Hardware Requirements to run the application
* 1.6 GHz or faster processor.
* 1 GB of RAM.
* 20 GB of free hard disk space (for Visual Studio 2013, if not already installed)
* 5400 RPM hard disk drive.
* DirectX 9-Capable Video card with 1024x768 of minimum resolution.

### How to Run the Application
1. Download/Clone the project from [here](https://github.com/szafar97/EADProject).
2. Run the *EAD_Project.sln* file in Visual Studio 2013 (or higher).
3. Click the browser name in toolbar (or press F5) to run the web application.
