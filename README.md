# CoreAPIUsingDapper
# Basic Example of .Net Core Using Dapper

1. Install Dapper from Nuget Package
2. Added new .Net Core Console App (Repository) into the solution
3. Added IEmployeeRepository and Implement IEmployeeRepository in EmployeeRepository
4. Added new .Net Core Console App (Service) into the solution
5. Added IEmployeeService and Implement IEmployeeService in EmployeeService and injected Repository dependency into the service.
6. Added Employee Controller and injected Employee Service dependency into the controller
7. Added Repository and Service Dependency into .Net Core Service inside StartUp.cs under ConfigureServices 
.

To Use MySQL 
1. Install MySQLConnect nuget package into Repository layer and add MySql.Data.MySqlClient
