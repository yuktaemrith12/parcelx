# 📦 Postal Management System - README

## 📌 Project Overview
The **Postal Management System** is a C# Windows Forms application designed to manage postal operations, including clients, packages, cash transfers, and postman details. The system utilizes a **hash table for fast lookups** and integrates with a **SQL Server database**.

---

## 🛠️ Setup & Installation

### **1. Requirements**
Before running the project, ensure you have the following installed:
- **Visual Studio** (2019 or later)
- **.NET Framework 4.7.2 or later**
- **Microsoft SQL Server** (Express or Developer Edition)
- **Git** (optional, for version control)

---

### **2. Clone the Repository**
If using Git, run the following command:
```sh
git clone https://github.com/yourusername/PostalManagementSystem.git
cd PostalManagementSystem
```

---

### **3. Database Setup**
1. Open **Microsoft SQL Server Management Studio (SSMS)**.
2. Execute the SQL script file **`CreateDatabase.sql`** to set up the database.
   - If using the SQL script manually, copy the contents and execute:
   ```sql
   CREATE DATABASE PostalManagementDB;
   USE PostalManagementDB;
   -- Run the table creation queries from CreateDatabase.sql
   ```
3. Make sure the connection string in `Program.cs` matches your SQL Server configuration.

---

## ▶️ Running the Application

### **1. Open Project in Visual Studio**
- Navigate to the project folder and open **`PostalCW.sln`** in **Visual Studio**.

### **2. Build & Compile**
- In **Visual Studio**, go to:
  - `Build` → `Build Solution` (`Ctrl + Shift + B`).

### **3. Run the Application**
- Press **F5** or click on the **Start Debugging** button.

---

## 📝 How to Use

### **1. Main Menu**
- The application opens to a **main menu** where you can navigate to:
  - **Package Management**
  - **Client Management**
  - **Cash Transfer**
  - **Postman Dashboard**

### **2. Postman Dashboard**
- Search for officers by **ID or Name**.
- Add, edit, and delete postman records.
- Uses a **hash table for quick retrieval**.

### **3. Package Management**
- Register new packages with sender and receiver details.
- Assign a delivery officer.
- Track package delivery.

### **4. Cash Transfer**
- Handle postal money transfers.
- Keep records of sender/receiver information.

### **5. Logout**
- Clicking **Logout** will **clear session data** and **exit the program**.

---

## 🐞 Troubleshooting

### **Database Connection Issues**
- If you get a **database connection error**, check:
  - Your SQL Server instance is running.
  - The connection string in `Program.cs` is correct.

### **Data Not Loading**
- Ensure **`PostmanData.txt`** exists in the project directory.
- Check the **LoadPostmanData()** function for errors.

---

## 👥 Contributors
- **Your Name**
- **Team Member 2**
- **Team Member 3**
- **Team Member 4**

---

## 📜 License
This project is licensed under the **MIT License**.

---

### 🚀 Enjoy using the Postal Management System! 🚀
