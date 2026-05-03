# Car Dealership Database Setup

## Instructions

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Copy the query below
4. Paste it into a new query window
5. Press **F5** or click **Execute** to run

## Database Query

```sql
-- =============================================
-- COMPLETE CAR DEALERSHIP DATABASE SETUP
-- Includes all tables with profile features, admin roles, stocks, and order logs
-- =============================================

-- Drop existing database if it exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'CarDealershipDB')
BEGIN
    ALTER DATABASE CarDealershipDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CarDealershipDB;
    PRINT 'Existing database dropped';
END
GO

-- Create new database
CREATE DATABASE CarDealershipDB;
PRINT 'Database CarDealershipDB created successfully';
GO

-- Use the database
USE CarDealershipDB;
GO

-- =============================================
-- CREATE USERS TABLE (with role field)
-- =============================================
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100) NULL,
    Email NVARCHAR(100) NULL,
    ProfileImage VARBINARY(MAX) NULL,
    Role NVARCHAR(20) DEFAULT 'User'
);
PRINT 'Users table created with profile and role fields';
GO

-- =============================================
-- INSERT TEST USERS
-- =============================================
INSERT INTO Users (Username, Password, FullName, Email, Role) 
VALUES ('admin', 'admin123', 'Administrator', 'admin@cardealership.com', 'Admin');

INSERT INTO Users (Username, Password, FullName, Email, Role) 
VALUES ('john', 'password123', 'John Doe', 'john.doe@example.com', 'User');

INSERT INTO Users (Username, Password, FullName, Email, Role) 
VALUES ('jane', 'password456', 'Jane Smith', 'jane.smith@example.com', 'User');

INSERT INTO Users (Username, Password, FullName, Email, Role) 
VALUES ('mike', 'mike123', NULL, NULL, 'User');

INSERT INTO Users (Username, Password, FullName, Email, Role) 
VALUES ('sarah', 'sarah123', NULL, NULL, 'User');

PRINT 'Test users inserted (5 users - 1 admin, 4 regular)';
GO

-- =============================================
-- CREATE CARS TABLE
-- =============================================
CREATE TABLE Cars (
    CarID INT PRIMARY KEY IDENTITY(1,1),
    ModelName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    ImageUrl NVARCHAR(500) NOT NULL,
    Year INT,
    Description NVARCHAR(MAX)
);
PRINT 'Cars table created';
GO

-- =============================================
-- CREATE STOCKS TABLE
-- =============================================
CREATE TABLE Stocks (
    StockID INT PRIMARY KEY IDENTITY(1,1),
    CarID INT FOREIGN KEY REFERENCES Cars(CarID),
    Description NVARCHAR(500),
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0
);
PRINT 'Stocks table created';
GO

-- =============================================
-- INSERT SAMPLE CARS
-- =============================================
INSERT INTO Cars (ModelName, Price, ImageUrl, Year, Description)
VALUES 
('Toyota Camry', 2657000.00, 'CarImages\\toyota-camry-removebg-preview.png', 2023, 'Reliable family sedan with excellent fuel economy'),
('Honda Civic', 1583000.00, 'CarImages\\honda-civic-removebg-preview.png', 2023, 'Sporty compact car with great handling'),
('Ford Mustang', 3506000.00, 'CarImages\\ford-mustang-removebg-preview.png', 2022, 'Iconic American muscle car with powerful engine'),
('Tesla Model 3', 1838000.00, 'CarImages\\tesla-model-3-removebg-preview.png', 2023, 'Electric performance sedan with autopilot'),
('BMW X5', 5990000.00, 'CarImages\\bmw-x5-removebg-preview.png', 2022, 'Luxury SUV with premium features'),
('Mercedes C-Class', 4125000.00, 'CarImages\\mercedes-cclass-removebg-preview.png', 2023, 'Luxury sedan with elegant design'),
('Audi A4', 3899000.00, 'CarImages\\audi-a4-removebg-preview.png', 2023, 'German engineering with Quattro all-wheel drive'),
('Hyundai Tucson', 1898000.00, 'CarImages\\hyundai-tucson-removebg-preview.png', 2023, 'Compact SUV with modern styling'),
('Nissan Altima', 1795000.00, 'CarImages\\nissan-altima-removebg-preview.png', 2023, 'Comfortable midsize sedan'),
('Chevrolet Camaro', 3650000.00, 'CarImages\\chevrolet-camaro-removebg-preview.png', 2022, 'American sports car with aggressive styling');

PRINT 'Sample cars inserted (10 cars)';
GO

-- =============================================
-- INSERT SAMPLE STOCKS
-- =============================================
INSERT INTO Stocks (CarID, Description, Price, Quantity)
VALUES 
(1, 'Toyota Camry Stock', 2657000.00, 5),
(2, 'Honda Civic Stock', 1583000.00, 3),
(3, 'Ford Mustang Stock', 3506000.00, 2),
(4, 'Tesla Model 3 Stock', 1838000.00, 4),
(5, 'BMW X5 Stock', 5990000.00, 1);

PRINT 'Sample stocks inserted (5 stocks)';
GO

-- =============================================
-- CREATE ORDER LOGS TABLE
-- =============================================
CREATE TABLE OrderLogs (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID NVARCHAR(50) NOT NULL,
    Username NVARCHAR(50) FOREIGN KEY REFERENCES Users(Username),
    CarID INT FOREIGN KEY REFERENCES Cars(CarID),
    StockID INT FOREIGN KEY REFERENCES Stocks(StockID),
    Quantity INT NOT NULL DEFAULT 1,
    TotalAmount DECIMAL(10,2) NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) DEFAULT 'Completed'
);
PRINT 'OrderLogs table created';
GO

-- =============================================
-- VERIFY ALL DATA
-- =============================================
PRINT '=========================================';
PRINT 'DATABASE SETUP VERIFICATION';
PRINT '=========================================';

-- Show Users data
PRINT '';
PRINT '--- USERS DATA ---';
SELECT 
    UserID,
    Username,
    Password,
    Role,
    CASE WHEN FullName IS NULL THEN '[Not Set]' ELSE FullName END AS FullName,
    CASE WHEN Email IS NULL THEN '[Not Set]' ELSE Email END AS Email
FROM Users;

-- Show Cars data
PRINT '';
PRINT '--- CARS DATA ---';
SELECT 
    CarID,
    ModelName,
    '₱' + FORMAT(Price, 'N0') AS Price,
    Year,
    LEFT(Description, 50) + '...' AS Description
FROM Cars;

-- Show Stocks data
PRINT '';
PRINT '--- STOCKS DATA ---';
SELECT 
    s.StockID,
    c.ModelName,
    s.Description,
    '₱' + FORMAT(s.Price, 'N0') AS Price,
    s.Quantity
FROM Stocks s
JOIN Cars c ON s.CarID = c.CarID;

-- Show statistics
PRINT '';
PRINT '=========================================';
PRINT 'DATABASE STATISTICS';
PRINT '=========================================';
SELECT 'Total Users' AS Item, COUNT(*) AS Count FROM Users
UNION ALL
SELECT 'Total Admins', COUNT(*) FROM Users WHERE Role = 'Admin'
UNION ALL
SELECT 'Total Cars', COUNT(*) FROM Cars
UNION ALL
SELECT 'Total Stocks', COUNT(*) FROM Stocks
UNION ALL
SELECT 'Total Order Logs', COUNT(*) FROM OrderLogs;

PRINT '';
PRINT '=========================================';
PRINT 'DATABASE SETUP COMPLETE!';
PRINT '=========================================';
PRINT '';
PRINT 'Test Login Credentials:';
PRINT '  Admin:  Username: admin | Password: admin123';
PRINT '  User:   Username: john  | Password: password123';
PRINT '  User:   Username: jane  | Password: password456';
PRINT '  User:   Username: mike  | Password: mike123';
PRINT '  User:   Username: sarah | Password: sarah123';
PRINT '';
PRINT 'Note: Admin account goes directly to AdminForm';
PRINT 'Regular users go to HomeForm';
PRINT '=========================================';
GO

```

## After Setup
Update your connection string in the C# code if needed:
```sql
_connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CarDealershipDB;Integrated Security=True;";
```

## Clone the repository
   ```bash
   git clone https://github.com/Mendokk007/CarDealership-latest.git
   ```
