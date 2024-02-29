![image](https://github.com/ratreprakash/MySqlWebApplication_AppConfiguration/assets/157607672/b1bbfc7f-07f7-4c9b-9c02-32793a7f1e0f)# MySqlWebApplication
	Clone the application and follow the instruction of implmnetion
# Prerequisite
  	1- Azure Data Studio 
	2- Visual Studio
        3- Azure Portal
# Setp of Implemnetion 
	1- Create A Resource group using your azure portal 
	2- Create App Service Plan
	3- Create A web app
	4- Create Azure SQL Server 
	5- Create Azure SQL Database 
	6- Build A web Application using Visual Studio with SQL database 
	7- Configuration of Connection string to access data from database in web app 
        8- Publish a web app in web app
# SQL Query 
		CREATE TABLE Products
		(
		     ProductID int,
		     ProductName varchar(1000),
		     Quantity int
		)




		INSERT INTO Products(ProductID,ProductName,Quantity) VALUES (2,'Laptop',20)
		
		INSERT INTO Products(ProductID,ProductName,Quantity) VALUES (1,'Tabs',30)
		
		INSERT INTO Products(ProductID,ProductName,Quantity) VALUES (3,'Mobile',10)

		SELECT * FROM Products
     	

# Architecture Diagram
![image](https://github.com/ratreprakash/MySqlWebApplication/assets/157607672/c9d51cce-a0f8-4c20-8790-bbf82ed6994b)

# Azure App Configuration
![image](https://github.com/ratreprakash/MySqlWebApplication_AppConfiguration/assets/157607672/c0d06009-f4fd-4bd1-92cb-352764470e34)

# Implementation of App configuration 

Create a  Azure App Configuration services and add connection string their.

Need to some code changes
	1- Install Nugget Package  Microsoft.Extensions.Configuration.AzureAppConfiguration
	2- Change in program.cs file 
		var connectionString = "Endpoint=https://myappconfiguration8900.azconfig.io;Id=h01p;Secret=JOgMWHpwvE3DS/0LJYsZvD7uvVzuJ0+N7dtqPUHORKc=";
		
		builder.Host.ConfigureAppConfiguration(builder =>
		{
		    builder.AddAzureAppConfiguration(connectionString);
		
		});
	3- Change is product service 
		SqlConnection(_configuration.["DefaultConnection"])



