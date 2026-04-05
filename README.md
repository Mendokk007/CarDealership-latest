# 🚗 Car Dealership Management System

A complete Windows Forms application for managing car dealership operations with user authentication, car browsing, profile management, and purchase tracking.

## 📋 Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [System Requirements](#system-requirements)
- [Installation Guide](#installation-guide)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [Login Credentials](#login-credentials)
- [Project Structure](#project-structure)
- [UI Features](#ui-features)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)

## ✨ Features

### User Features
- **User Authentication**: Secure login and registration system
- **Profile Management**: Upload profile pictures, add full name and email
- **Car Catalog**: Browse cars with image carousel (auto-slides every 8 seconds)
- **Car Purchase**: Select and purchase cars with confirmation
- **Custom UI**: Modern dark theme with red accents
- **Draggable Windows**: Borderless forms with custom title bars

### Admin Features
- **Manage Cars**: Add, edit, or remove car listings
- **View Purchases**: Track all customer purchases
- **User Management**: View registered users

## 🛠 Technologies Used

- **Frontend**: Windows Forms (.NET Framework 4.7.2+)
- **Backend**: C#
- **Database**: Microsoft SQL Server
- **Graphics**: GDI+ for circular profile images
- **Version Control**: Git & GitHub

## 💻 System Requirements

- Windows 7/8/10/11
- .NET Framework 4.7.2 or higher
- SQL Server 2012 or higher (Express edition works)
- Visual Studio 2019/2022 (for development)
- 2GB RAM minimum
- 100MB free disk space

## 📥 Installation Guide

### For Users (Just Running the App)

1. **Clone the repository**
   ```bash
   git clone https://github.com/Mendokk007/CarDealership-latest.git
Navigate to the project folder

bash
cd CarDealership-latest
Open the solution

Double-click CarDealership.sln to open in Visual Studio

For Developers (Full Setup)
Install Visual Studio 2022 with these workloads:

.NET desktop development

Data storage and processing

Install SQL Server (if not already installed):

Download SQL Server Express from Microsoft

Install with default settings

Install SQL Server Management Studio (SSMS)

Clone the repository

bash
git clone https://github.com/Mendokk007/CarDealership-latest.git
🗄 Database Setup
Automatic Setup (Recommended)
Open SQL Server Management Studio (SSMS)

Connect to your SQL Server instance (usually .\SQLEXPRESS or localhost)

Click File → Open → File or press Ctrl + O

Navigate to the project folder and select DatabaseSetup.sql

Press F5 or click Execute to run the script

The script will automatically:

Create the CarDealershipDB database

Create all necessary tables (Users, Cars, Purchases)

Insert 10 sample cars with images

Insert 5 test users with profile fields

Add profile picture support

What the Database Script Creates
Users Table:

UserID (Primary Key)

Username (Unique, required)

Password (Required)

FullName (Optional)

Email (Optional)

ProfileImage (Optional, stores profile pictures)

Cars Table:

CarID (Primary Key)

ModelName

Price

ImageUrl (path to car image)

Year

Description

Purchases Table:

PurchaseID (Primary Key)

CarID (Foreign Key)

Username (Foreign Key)

PurchaseDate (Auto-generated)

TotalAmount

Update Connection String
After database setup, update the connection string in your C# code if needed:

csharp
// In LoginForm.cs, RegisterForm.cs, and HomeForm.cs
// Default connection string (uses local SQL Express):
_connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CarDealershipDB;Integrated Security=True;";

// If using a different SQL Server instance:
_connectionString = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=CarDealershipDB;Integrated Security=True;";

// If using SQL Server authentication:
_connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CarDealershipDB;User Id=sa;Password=your_password;";
Car Images Setup
Create a folder named CarImages in the application directory (bin\Debug\ or bin\Release\)

Add the car images with these exact filenames:

toyota-camry-removebg-preview.png

honda-civic-removebg-preview.png

ford-mustang-removebg-preview.png

tesla-model-3-removebg-preview.png

bmw-x5-removebg-preview.png

mercedes-cclass-removebg-preview.png

audi-a4-removebg-preview.png

hyundai-tucson-removebg-preview.png

nissan-altima-removebg-preview.png

chevrolet-camaro-removebg-preview.png

Or modify the ImageUrl paths in the database to match your image locations

Logo Setup (Optional)
Create a folder named Logos in the application directory

Add your custom logo as logo.png (recommended size: 100x50 pixels)

The logo will automatically display in the center of the top bar

🚀 Running the Application
From Visual Studio
Open CarDealership.sln in Visual Studio

Build the solution (Ctrl + Shift + B)

Press F5 or click Start to run

The Login Form will appear

From Executable
Navigate to bin\Debug\ or bin\Release\

Double-click CarDealership.exe

Login with credentials below

🔐 Login Credentials
Username	Password	Role	Profile Status
admin	admin123	Administrator	Has profile info
john	password123	Regular User	Has profile info
jane	password456	Regular User	Has profile info
mike	mike123	Regular User	No profile (add yours)
sarah	sarah123	Regular User	No profile (add yours)
📁 Project Structure
text
CarDealership/
├── CarDealership.sln              # Visual Studio solution
├── README.md                       # This file
├── DatabaseSetup.sql               # Database creation script
├── LoginForm.cs                    # Login form logic
├── LoginForm.Designer.cs           # Login form design
├── RegisterForm.cs                 # Registration form
├── RegisterForm.Designer.cs        # Registration form design
├── HomeForm.cs                     # Main dashboard logic
├── HomeForm.Designer.cs            # Main dashboard design
├── EditProfileForm.cs              # Profile editing logic
├── EditProfileForm.Designer.cs     # Profile editing design
├── PurchaseForm.cs                 # Purchase logic
├── PurchaseForm.Designer.cs        # Purchase design
├── CarImages/                      # Car images folder
│   ├── toyota-camry-removebg-preview.png
│   ├── honda-civic-removebg-preview.png
│   ├── ford-mustang-removebg-preview.png
│   ├── tesla-model-3-removebg-preview.png
│   ├── bmw-x5-removebg-preview.png
│   ├── mercedes-cclass-removebg-preview.png
│   ├── audi-a4-removebg-preview.png
│   ├── hyundai-tucson-removebg-preview.png
│   ├── nissan-altima-removebg-preview.png
│   └── chevrolet-camaro-removebg-preview.png
└── Logos/                          # Custom logos folder (optional)
    └── logo.png                    # Your custom logo (100x50 recommended)
🎨 UI Features
Login Form
Borderless custom window

Draggable title bar

Red close button with hover effects

Register and Delete Account links

Dark theme with red accents

Home Dashboard
Top Bar Layout:

Left: Profile section with circular picture, welcome message, and edit profile link

Center: Custom logo (supports uploaded images)

Right: Logout button with hover effects

Car Carousel:

Auto-slides every 8 seconds

Manual navigation with Previous/Next buttons

Zoomed image display with transparency support

Price displayed in red with Philippine Peso format

Select Car Button: Opens purchase confirmation dialog

Edit Profile Form
Borderless custom window with close button

Circular profile picture with upload support

Full name and email fields

Image preview with circular cropping

Save and Cancel buttons

Purchase Form
Car image display

Car model and price

Customer information

Confirm purchase with success message

🔧 Troubleshooting
Database Connection Error
Error: Cannot open database "CarDealershipDB" or Login failed for user

Solutions:

Run the DatabaseSetup.sql script in SSMS

Check your SQL Server instance name in SSMS

Update connection string in all forms:

LoginForm.cs

RegisterForm.cs

HomeForm.cs

Make sure SQL Server service is running

Enable TCP/IP protocol in SQL Server Configuration Manager

Image Not Found Error
Error: Car images not displaying (shows "Image Not Found" placeholder)

Solutions:

Create a CarImages folder in bin\Debug\ or bin\Release\

Add the car images with exact filenames from the database

Or update ImageUrl paths in the Cars table:

sql
UPDATE Cars SET ImageUrl = 'YourCustomPath\\image.png' WHERE CarID = 1;
Profile Picture Not Saving
Error: Profile image doesn't update or save

Solutions:

Ensure the ProfileImage column exists in Users table

Run the full DatabaseSetup.sql script to add missing columns

Check file permissions in the application folder

Image is automatically resized to 300x300 before saving

Build Errors
Error: Missing references or using directives

Solutions:

Right-click References → Add Reference

Add these assemblies:

System.Drawing

System.Data

System.Windows.Forms

Clean and rebuild solution (Build → Clean Solution, then Build → Rebuild Solution)

Logo Not Displaying
Error: Logo area is blank

Solutions:

Create a Logos folder in the application directory

Add logo.png file (recommended size: 100x50 pixels)

The app will show a default "2F SUPER CARS" text logo if no image is found

Form Drag Not Working
Error: Cannot drag the window

Solutions:

Make sure you're clicking on the top panel (dark gray area)

Click and hold on empty space (not on buttons)

The Edit Profile link won't drag (keeps click functionality)

🤝 Contributing
Fork the repository

Create a feature branch (git checkout -b feature/AmazingFeature)

Commit changes (git commit -m 'Add AmazingFeature')

Push to branch (git push origin feature/AmazingFeature)

Open a Pull Request

📝 License
This project is for educational purposes only.

👥 Author
Mendokk007

🙏 Acknowledgments
Icons and car images from various sources

Inspired by modern car dealership websites

UI design influenced by Discord's dark theme

📞 Support
For issues or questions:

Check the Troubleshooting section above

Open an issue on GitHub: https://github.com/Mendokk007/CarDealership-latest/issues

Contact the development team

🎯 Future Updates
Planned features for future releases:

Admin dashboard for managing cars

Purchase history for users

Email confirmation for registration

Password recovery feature

Export purchase reports to PDF

Multiple currency support

Dark/Light theme toggle

Made with ❤️ for the Car Dealership Management System

Version 1.0.0 | Last Updated: 2024

text

## How to Save:

1. **Copy all the text above**
2. Open **Notepad** or any text editor
3. **Paste** the text
4. Click **File → Save As**
5. Navigate to your project folder
6. Change "Save as type" to **"All Files (*.*)"**
7. File name: `README.md`
8. Click **Save**

Then in Git Bash:
```bash
git add README.md
git commit -m "Add complete README file"
git push origin main
