# STORE MANAGEMENT DESKTOP APPLICATION 🏪

An end-of-training project built with C# and SQL Server. The application helps manage daily supermarket operations, including inventory, customer orders, employee records, and data reporting through a Windows Forms interface.

## FEATURES ✨

- **Inventory Management** — Manage products and stock levels, with automatic stock deductions when order items are added.
- **Order Processing** — Create and manage customer orders with automatic total calculations based on ordered items.
- **Customer Management** — Maintain customer records with search and filtering capabilities.
- **Employee Management** — Manage employee records with separate administrator and employee access.
- **Data Export** — Export application data in XML, XSD, and HTML formats.
- **Charts & Reporting** — Visualize customer order counts, ordered product quantities, and stock levels.
- **Dark Mode** — Switch between light and dark themes across the application interface.

## TECHNOLOGIES 🚀

- **C#** — Programming language used for application development.
- **.NET Framework 4.7.2** — Application framework used to build and run the desktop application.
- **Windows Forms** — UI framework for building the desktop interface.
- **SQL Server** — Relational database management system for storing application data.
- **ADO.NET** — Data access technology used to communicate with SQL Server.

## DEMO 🎬

Watch the demo on [YouTube](https://youtu.be/YDySGsynk7Q).

## PREREQUISITES 📋

Before getting started, ensure you have the following:

- **Windows** — Required to run the Windows Forms application.
- **Visual Studio** — With the .NET desktop development workload and .NET Framework 4.7.2 targeting components installed.
- **SQL Server** — A local or accessible SQL Server instance.
- **SQL Server Management Studio** — Or another SQL client for database initialization.

The project references an external `ExcelLibrary.dll` assembly that is not included in the repository and may need to be resolved before building.

## INSTALLATION ⚙️

1. Clone the repository to your local machine.
2. Open `Gestion d'un Supermarché.sln` in Visual Studio.
3. Create the `Supermarché` database in SQL Server.
4. Open `Gestion d'un Supermarché.sql` and execute the database schema, triggers, and sample-data statements against the created database. The initial database creation and selection statements may need to be executed as separate SQL batches.
5. Configure the SQL Server instance through the application's server settings interface, which stores the selected server in the `NomServeur` setting. The connection uses Windows integrated authentication.
6. Resolve the external `ExcelLibrary.dll` reference if Visual Studio reports a missing dependency. The required assembly is not supplied with the repository.
7. Build and run the application from Visual Studio.

The SQL script contains sample data, but a complete clean-build and login procedure has not been verified against a fresh environment.

## CONTRIBUTING 🤝

Contributions are welcome! Please follow these guidelines:

1. Follow the existing project structure and coding conventions.
2. Use [Conventional Commits](https://www.conventionalcommits.org/) for commit messages.
3. Test your changes locally whenever possible.
4. Update the documentation when introducing new features or changing existing functionality.

## LICENSE 📄

This project is licensed under the [MIT License](LICENSE).

## CONTACT 📧

For any questions or feedback, reach out at [contact@aimanecouissi.com](mailto:contact@aimanecouissi.com).
