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
2. Creating animals table is part of an application so you just have to click the Create Table button in UI
   and seed this table with the animals.txt file attached to the project in SOCAnimalShelterDataMigration\Data project folder
   (on main app page there is textbox to specify a path to file) and then click Start Data Migration button.
   If you have any questions please do not hesitate to contact me:).
