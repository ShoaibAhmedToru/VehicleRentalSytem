VEHICLE RENTAL SYSTEM - SETUP
================================

Requirements:
- Visual Studio 2019/2022 with .NET desktop development workload
- SQL Server Express instance: EMPRESS\SQLEXPRESS
- SQL Server Management Studio

FIRST RUN
1. Open SSMS and connect to EMPRESS\SQLEXPRESS using Windows Authentication.
2. Open DatabaseSetup.sql.
3. Click Execute. It creates/updates VehicleRentDB and adds sample vehicles.
4. Open VehicleRentalSystem.sln in Visual Studio.
5. Build > Rebuild Solution, then press F5.

ADMIN LOGIN
Username: admin
Password: admin123

CUSTOMER LOGIN
Log in as admin and use "Create Customer Account" below the Reports button.
The login form intentionally does not allow public customer registration.

IMPORTANT
The connection string is in DataAccess.cs. If your SQL Server instance name is
different, change Data Source there. The current value matches EMPRESS\SQLEXPRESS.

FEATURES
- Admin/customer authentication and role dashboards
- Vehicle and customer management
- Vehicle search, booking, cancellation, pickup and return
- Automatic duration, rental cost and late charge calculations
- Cash/card/online payment handling inside My Rentals
- Rental filtering, status management and report summary
- Parameterized SQL and input validation

THE 9 WINDOWS FORMS
1. LoginForm
2. RegistrationForm (admin-only customer creation)
3. AdminDashboard
4. CustomerDashboard
5. VehicleForm
6. CustomerForm
7. AvailableVehiclesForm
8. MyRentalsForm (includes payments)
9. RentalManagementForm (also provides report filtering and summary)

The project does not use form .resx files.
It runs locally and does not require an internet connection.

CODE ORGANIZATION
- Form.Designer.cs: control declarations, creation, layout, colors and fixed items.
- Form.cs: events, navigation, validation, calculations and database operations.
- DataAccess.cs: SQL Server connection and reusable query methods.
