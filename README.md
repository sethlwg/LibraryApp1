# LibraryApp1

This is a web application that allows users to search for books, view details about them and manage the collection of books.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)

## Introduction

The libraryApp is designed to help users easily manage and search for books in a library. It includes features like creating new books, adding new books, updating new books, deleting new books and viewing detailed information about each book.

## Features

-Search for books via title or author.
-View detailed information about each book.
-Create a new book for the book collection.
-Add a new book to the collection.
-Update existing book information.
-Delete books from the collection.

## Installation

### Prerequisites

- [.Net 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [Visual Studio Code](https://code.visualstudio.com/)

### Steps

1. Clone the repository:

use gitbash on windows or in VSCODE terminal.
git clone https://github.com/sethlwg/LibraryApp1.git
cd LibraryApp1

dotnet restore
dotnet build

dotnet run OR
dotnet watch run for hot reload(As a change is made in a file it will appear in the web browser)

### Usage

1. After dotnet run or dotnet watch run is ran navigate to the localhost from terminal which should be 'http://localhost:5124'.
2. Use the search bar on the home page to search for books.
3. Clock on details for view more information about the book.
4. Use the 'Add Book' to add new books to the collection.
5. Update or delete books using the corresponding buttons on the book details page.

## Contributing

We welcome contributions to enhance LibraryApp1. To contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch ('git checkout -b feature/YourFeature').
3. Commit you changes ('git commit -m 'Add new feature').
4. Push to the branch ('git push origin feature/YourFeature').
5. Open a pull request.

Please ensure your code adheres to our coding standards and includes appropriate tests.
