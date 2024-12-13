-- Table for Book Genres
-- This table defines different genres of books in the library.
CREATE TABLE book_genre (
    genre_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each genre
    genre_name NVARCHAR(100) -- Name of the book genre
);

-- Publishers Table
-- This table defines different publishers in the library.
CREATE TABLE publishers (
    publisher_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each publisher
    publisher_name NVARCHAR(100) -- Name of the publisher
);

-- Books Table
-- This table stores information about the books in the library.
CREATE TABLE books (
    book_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each book
    book_title NVARCHAR(100), -- Title of the book
    genre INT FOREIGN KEY REFERENCES book_genre(genre_id), -- Genre to which the book belongs
    publisher INT FOREIGN KEY REFERENCES publishers(publisher_id), -- Publisher of the book
    publication_date DATE, -- Publication date of the book
    language NVARCHAR(50), -- Language of the book
    ISBN NVARCHAR(13) UNIQUE, -- International Standard Book Number
    number_of_pages INT
);

-- Authors Table
-- This table stores information about the authors in the library.
CREATE TABLE authors (
    author_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each author
    name NVARCHAR(100), -- Name of the author
    date_of_birth DATE, -- Date of birth of the author
    nationality NVARCHAR(50) -- Nationality of the author
);

-- Books-Authors Relationship Table
-- This table stores the relationship between books and authors.
CREATE TABLE books_authors (
    book_id INT FOREIGN KEY REFERENCES books(book_id), -- Book ID
    author_id INT FOREIGN KEY REFERENCES authors(author_id), -- Author ID
    PRIMARY KEY (book_id, author_id) -- There can be multiple authors for a book
);

-- Members Table
-- This table stores information about the library members.
CREATE TABLE members (
    member_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each member
    ID_number NVARCHAR(11) UNIQUE, -- Member ID number
    first_name NVARCHAR(50), -- Member's first name
    last_name NVARCHAR(50), -- Member's last name
    email NVARCHAR(100) UNIQUE, -- Member's email address
    phone_number NVARCHAR(15) UNIQUE, -- Member's phone number
    total_fines_paid INT -- Total amount of fines paid by the member
);

-- Loans Table
-- This table stores information about the books borrowed from the library.
CREATE TABLE loans (
    loan_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each loan transaction
    book_id INT FOREIGN KEY REFERENCES books(book_id), -- ID of the borrowed book
    member_id INT FOREIGN KEY REFERENCES members(member_id), -- ID of the borrowing member
    loan_date DATE NOT NULL, -- Date the book was borrowed
    return_date DATE, -- Date the book is due to be returned (null if not returned yet)
    fine_amount INT -- Amount of fine incurred from the borrowed book
);

-- Administrators Table
-- This table stores information about the library administrators.
CREATE TABLE administrators (
    admin_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each administrator
    username NVARCHAR(100) UNIQUE, -- Administrator username
    password NVARCHAR(100), -- Administrator password
    full_name NVARCHAR(255) UNIQUE, -- Administrator's full name
    email NVARCHAR(255), -- Administrator's email address
    phone_number NVARCHAR(15), -- Administrator's phone number
    role NVARCHAR(50) -- Administrator role ("admin", "super_admin", etc.)
);

-- Permissions Table
-- This table stores the permissions that can be assigned to administrators.
CREATE TABLE permissions (
    permission_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each permission
    permission_type NVARCHAR(100) -- Type of permission ("add book", "delete member", etc.)
);

-- Administrators-Permissions Relationship Table
-- This table stores the permissions assigned to administrators.
CREATE TABLE administrators_permissions (
    administrator_id INT FOREIGN KEY REFERENCES administrators(admin_id), -- Administrator ID
    permission_id INT FOREIGN KEY REFERENCES permissions(permission_id), -- Permission ID
    PRIMARY KEY (administrator_id, permission_id) -- An administrator can have multiple permissions
);

-- Library Staff Table
-- This table stores information about the library staff.
CREATE TABLE library_staff (
    staff_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique identifier for each staff member
    full_name NVARCHAR(255), -- Staff member's full name
    position NVARCHAR(100), -- Staff member's position ("librarian", "assistant", etc.)
    email NVARCHAR(255), -- Staff member's email address
    phone_number NVARCHAR(15) -- Staff member's phone number
);








-- Insert data into book_genre table
INSERT INTO book_genre (genre_name)
VALUES 
    ('Fiction'),
    ('Non-Fiction'),
    ('Science Fiction'),
    ('Fantasy'),
    ('Mystery'),
    ('Romance'),
    ('Biography'),
    ('Self-Help'),
    ('History'),
    ('Poetry');

-- Insert data into publishers table
INSERT INTO publishers (publisher_name)
VALUES 
    ('Penguin Random House'),
    ('HarperCollins'),
    ('Simon & Schuster'),
    ('Macmillan'),
    ('Hachette Livre'),
    ('Oxford University Press'),
    ('Cambridge University Press'),
    ('Pearson'),
    ('Routledge'),
    ('Wiley');

-- Insert data into books table
INSERT INTO books (book_title, genre, publisher, publication_date, language, ISBN, number_of_pages)
VALUES 
    ('The Great Gatsby', 1, 1, '1925-04-10', 'English', '9780743273565', 218),
    ('Sapiens: A Brief History of Humankind', 2, 2, '2011-09-04', 'English', '9780062316097', 498),
    ('Dune', 3, 3, '1965-08-01', 'English', '9780441013593', 412),
    ('Harry Potter and the Sorcerer''s Stone', 4, 4, '1997-06-26', 'English', '9780590353427', 309), -- Fixed apostrophe
    ('The Girl with the Dragon Tattoo', 5, 5, '2005-08-01', 'Swedish', '9780307454546', 465),
    ('Pride and Prejudice', 6, 6, '1813-01-28', 'English', '9780141439518', 279),
    ('The Diary of a Young Girl', 7, 7, '1947-06-25', 'Dutch', '9780553296983', 283),
    ('The Power of Habit', 8, 8, '2012-02-28', 'English', '9780812981605', 371),
    ('The History of the Ancient World', 9, 9, '2007-09-04', 'English', '9780393059748', 672),
    ('The Waste Land', 10, 10, '1922-12-01', 'English', '9780811218846', 64);

-- Insert data into authors table
INSERT INTO authors (name, date_of_birth, nationality)
VALUES 
    ('F. Scott Fitzgerald', '1896-09-24', 'American'),
    ('Yuval Noah Harari', '1976-02-24', 'Israeli'),
    ('Frank Herbert', '1920-10-08', 'American'),
    ('J.K. Rowling', '1965-07-31', 'British'),
    ('Stieg Larsson', '1954-08-15', 'Swedish'),
    ('Jane Austen', '1775-12-16', 'British'),
    ('Anne Frank', '1929-06-12', 'German-Dutch'),
    ('Charles Duhigg', '1974-04-01', 'American'),
    ('Susan Wise Bauer', '1968-01-10', 'American'),
    ('T.S. Eliot', '1888-09-26', 'American-British');

-- Insert data into books_authors relationship table
INSERT INTO books_authors (book_id, author_id)
VALUES 
    (1, 1),  -- The Great Gatsby by F. Scott Fitzgerald
    (2, 2),  -- Sapiens by Yuval Noah Harari
    (3, 3),  -- Dune by Frank Herbert
    (4, 4),  -- Harry Potter by J.K. Rowling
    (5, 5),  -- The Girl with the Dragon Tattoo by Stieg Larsson
    (6, 6),  -- Pride and Prejudice by Jane Austen
    (7, 7),  -- The Diary of a Young Girl by Anne Frank
    (8, 8),  -- The Power of Habit by Charles Duhigg
    (9, 9),  -- The History of the Ancient World by Susan Wise Bauer
    (10, 10); -- The Waste Land by T.S. Eliot

-- Insert data into members table
INSERT INTO members (ID_number, first_name, last_name, email, phone_number, total_fines_paid)
VALUES 
    ('12345678901', 'John', 'Doe', 'john.doe@example.com', '555-1234', 0),
    ('98765432100', 'Jane', 'Smith', 'jane.smith@example.com', '555-5678', 5),
    ('11223344556', 'Emily', 'Johnson', 'emily.johnson@example.com', '555-9101', 10),
    ('22334455667', 'Michael', 'Williams', 'michael.williams@example.com', '555-1122', 0),
    ('33445566778', 'Sarah', 'Brown', 'sarah.brown@example.com', '555-3344', 2);

-- Insert data into loans table
INSERT INTO loans (book_id, member_id, loan_date, return_date, fine_amount)
VALUES 
    (1, 1, '2024-12-01', '2024-12-10', 0),
    (2, 2, '2024-12-02', '2024-12-16', 0),
    (3, 3, '2024-12-03', '2024-12-20', 5),
    (4, 4, '2024-12-04', NULL, 0),
    (5, 5, '2024-12-05', '2024-12-12', 0);

-- Insert data into administrators table
INSERT INTO administrators (username, password, full_name, email, phone_number, role)
VALUES 
    ('admin1', 'password123', 'Alice Williams', 'alice.williams@library.com', '555-5678', 'admin'),
    ('admin2', 'password456', 'Bob Johnson', 'bob.johnson@library.com', '555-1234', 'super_admin');

-- Insert data into permissions table
INSERT INTO permissions (permission_type)
VALUES 
    ('add book'),
    ('delete member'),
    ('view loans'),
    ('manage fines'),
    ('update book info');

-- Insert data into administrators_permissions relationship table
INSERT INTO administrators_permissions (administrator_id, permission_id)
VALUES 
    (1, 1),  -- Alice has permission to add books
    (1, 2),  -- Alice has permission to delete members
    (2, 3),  -- Bob has permission to view loans
    (2, 4);  -- Bob has permission to manage fines

-- Insert data into library_staff table
INSERT INTO library_staff (full_name, position, email, phone_number)
VALUES 
    ('Rachel Green', 'Librarian', 'rachel.green@library.com', '555-4321'),
    ('Monica Geller', 'Assistant Librarian', 'monica.geller@library.com', '555-8765');
