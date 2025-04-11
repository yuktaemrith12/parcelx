

# 📦 Postal Management System – README

##  Project Overview

The Postal Management System is a **C# Windows Forms application** designed to assist postal staff in managing **clients**, **packages**, **cash transfers**, and **postman details**. The system integrates a **custom hash table** for fast in-memory data operations and connects to a **Microsoft SQL Server** database for persistent storage.

At startup, users are prompted to either **import postman data from a text file** or skip the import if records already exist in the database.

---

##  Setup & Installation

### 1. Requirements

Make sure you have the following installed:

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- Microsoft SQL Server (Express or Developer Edition)
- Git (optional, for version control)

---

### 2. Clone the Repository

If using Git:
```bash
git clone https://github.com/yourusername/PostalManagementSystem.git
cd PostalManagementSystem
```

---

### 3. Database Setup

1. Open **Microsoft SQL Server Management Studio (SSMS)**
2. Run the contents of `CreateDatabase.sql`:
   ```sql
   CREATE DATABASE ParcelX_dB;
   USE ParcelX_dB;
   -- Run the rest of the table creation and constraints as per CreateDatabase.sql
   ```

3. Ensure that the **connection string** in `Program.cs` points to your correct SQL Server instance. Example:
   ```csharp
   @"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
   ```

---

##  Running the Application

### 1. Open the Solution

Open `PostalCW.sln` in Visual Studio.

### 2. Build the Project

Go to **Build → Build Solution** or press `Ctrl + Shift + B`.

### 3. Run the Application

Press `F5` or click the **Start Debugging** button.

---

##  How to Use the Application

###  Startup File Path Input

On launch, you will be prompted to:
- Enter or browse a file path to `PostmanData.txt` (containing postman records), OR
- Click **Skip** if the database already has postmen

Only **unique officers** (based on OfficerID) will be inserted into the database.

---

###  Main Menu Navigation

Use the main menu icons to access the following modules:

####  Package Management
- Register packages with sender and receiver info
- Assign delivery officers
- Update package delivery status

####  Client Management
- Add, search, update, and remove clients
- View clients in a DataGridView
- Uses a hash table for fast lookup

####  Cash Transfer
- Record postal money transfers
- Capture sender, receiver, and amount details
- Validate and store data securely

####  Postman Dashboard
- Add, edit, delete officers
- Search by ID or Name (autocomplete enabled)
- Data loaded into a custom hash table for instant filtering

---

###  Logout

Click **Logout** to exit the system. The application no longer deletes postman data on logout — records are preserved in the database.

---

##  Troubleshooting

### ⚠️ Database Connection Issues

Check:
- SQL Server is running
- Connection string in `Program.cs` is correct
- Database `ParcelX_dB` has been created and contains the required tables

### ⚠️ File Not Found / Data Not Loaded

- Ensure `PostmanData.txt` exists if you're inserting data
- Check that the file format is correct (CSV-like, 6 fields per line)
- Verify `LoadPostmanData()` logic in `Program.cs`

---

##  Technologies Used

- C# (.NET Framework)
- Windows Forms (WinForms)
- Microsoft SQL Server
- Custom Generic Hash Table (`HashTable<T>`)

