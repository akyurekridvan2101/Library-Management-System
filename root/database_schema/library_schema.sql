-- Table for Book Genres
-- This table defines different genres of books in the library.
CREATE TABLE book_genre (
    genre_id SERIAL PRIMARY KEY, -- Unique identifier for each genre
    genre_name VARCHAR(100) -- Name of the book genre
);

-- Publishers Table
-- This table defines different publishers in the library.
CREATE TABLE publishers (
    publisher_id SERIAL PRIMARY KEY, -- Unique identifier for each publisher
    publisher_name VARCHAR(100) -- Name of the publisher
);

-- Books Table
-- This table stores information about the books in the library.
CREATE TABLE books (
    book_id SERIAL PRIMARY KEY, -- Unique identifier for each book
    book_title VARCHAR(100), -- Title of the book
    genre INT REFERENCES book_genre(genre_id), -- Genre to which the book belongs
    publisher INT REFERENCES publishers(publisher_id), -- Publisher of the book
    publication_date DATE, -- Publication date of the book
    language VARCHAR(50), -- Language of the book
    ISBN VARCHAR(13) UNIQUE -- International Standard Book Number
);

-- Authors Table
-- This table stores information about the authors in the library.
CREATE TABLE authors (
    author_id SERIAL PRIMARY KEY, -- Unique identifier for each author
    name VARCHAR(100), -- Name of the author
    date_of_birth DATE, -- Date of birth of the author
    nationality VARCHAR(50) -- Nationality of the author
);

-- Books-Authors Relationship Table
-- This table stores the relationship between books and authors.
CREATE TABLE books_authors (
    book_id INT REFERENCES books(book_id), -- Book ID
    author_id INT REFERENCES authors(author_id), -- Author ID
    PRIMARY KEY (book_id, author_id) -- There can be multiple authors for a book
);

-- Members Table
-- This table stores information about the library members.
CREATE TABLE members (
    member_id SERIAL PRIMARY KEY, -- Unique identifier for each member
    ID_number VARCHAR(11) UNIQUE, -- Member ID number
    first_name VARCHAR(50), -- Member's first name
    last_name VARCHAR(50), -- Member's last name
    email VARCHAR(100) UNIQUE, -- Member's email address
    phone_number VARCHAR(15) UNIQUE, -- Member's phone number
    total_fines_paid INT -- Total amount of fines paid by the member
);

-- Loans Table
-- This table stores information about the books borrowed from the library.
CREATE TABLE loans (
    loan_id SERIAL PRIMARY KEY, -- Unique identifier for each loan transaction
    book_id INT REFERENCES books(book_id), -- ID of the borrowed book
    member_id INT REFERENCES members(member_id), -- ID of the borrowing member
    loan_date DATE NOT NULL, -- Date the book was borrowed
    return_date DATE, -- Date the book is due to be returned (null if not returned yet)
    fine_amount INT -- Amount of fine incurred from the borrowed book
);

-- Administrators Table
-- This table stores information about the library administrators.
CREATE TABLE administrators (
    admin_id SERIAL PRIMARY KEY, -- Unique identifier for each administrator
    username VARCHAR(100) UNIQUE, -- Administrator username
    password VARCHAR(100), -- Administrator password
    full_name VARCHAR(255) UNIQUE, -- Administrator's full name
    email VARCHAR(255), -- Administrator's email address
    phone_number VARCHAR(15), -- Administrator's phone number
    role VARCHAR(50) -- Administrator role ("admin", "super_admin", etc.)
);

-- Permissions Table
-- This table stores the permissions that can be assigned to administrators.
CREATE TABLE permissions (
    permission_id SERIAL PRIMARY KEY, -- Unique identifier for each permission
    permission_type VARCHAR(100) -- Type of permission ("add book", "delete member", etc.)
);

-- Administrators-Permissions Relationship Table
-- This table stores the permissions assigned to administrators.
CREATE TABLE administrators_permissions (
    administrator_id INTEGER REFERENCES administrators(admin_id), -- Administrator ID
    permission_id INTEGER REFERENCES permissions(permission_id), -- Permission ID
    PRIMARY KEY (administrator_id, permission_id) -- An administrator can have multiple permissions
);

-- Library Staff Table
-- This table stores information about the library staff.
CREATE TABLE library_staff (
    staff_id SERIAL PRIMARY KEY, -- Unique identifier for each staff member
    full_name VARCHAR(255), -- Staff member's full name
    position VARCHAR(100), -- Staff member's position ("librarian", "assistant", etc.)
    email VARCHAR(255), -- Staff member's email address
    phone_number VARCHAR(15) -- Staff member's phone number
);


