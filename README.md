# AnimalShelterCRUDApplication

This is simple CRUD application with more complex backend (without ORM and with separation of concerns pattern).
I started building this application after my Alx .NET C# Bootcamp. The goal was to preserve knowledge gained at that course. 
Application works with SQL Server LocalDb.
There are four projects in the solution. 
Because I followed the separation of concerns pattern this app is combined from four projects:
1. Class library.
2. Data migration console application with model, repository, controller and tooling classes.
3. Windows Forms User Interface.
4. ASP.NET Web Forms User Interface.

To run the application:
1. Create Animals Database at (localdb)\MSSQLLocalDB instance.
2. Creating animals table is a part of application so you just have to click the Create Table button in UI
   and seed this table with the animals.txt file attached to the project in SOCAnimalShelterDataMigration\Data project folder
   (on main app Windows Forms page there is a Browse File button and a textbox where file localization and name will appear, with Web Forms UI please enter a path directly to textbox).
3. Click Start Data Migration button.

   If you have any questions please do not hesitate to contact me:).
