							 CSC 511 Course Project Readme
							-------------------------------

This is similar to Amazon website, the user can signup and signin into our application and can start searching for different variety of products in Items page. 


Technologies Used
-------------------
This section is going to list down all the frameworks/libraries used to build our project. Here are a few examples.
* .NET 6.0
* ASP.NET
* C#
* SQL Server and Database


Getting Started
-----------------
This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

Prerequisites
---------------
Following list of softwares are required to run this application.

	* Visual Studio/Visual Studio Code
	* .NET 6.0
	* Nuget packages
	* Entity Framework
	* SQL Server
	* SQL Database

Installation
--------------
Below is an example of how you can instruct your audience on installing and setting up our applciation:

	1. Download the uploaded solution in the canvas and Extract it.
	2. Install nuget packages (if required)
	3. Open .sln file in Visual studio
	4. Get the Connection string for database and add into solution
	5. Build the solution by Clicking on 'CTRL + SHIFT + B'
	6. Select Amazon project as startup project in the Solution Explorer and
	7. Run the solution


Test code
-----------
We can test the application code by using following testcases.

Functional Tests
--------------------

Test 1:
Verify Username and Password fields with invalid input text. 
Expected Result – It should display error message as “Invalid Username or Password” 

Test 2:
Verify Sign in button works for valid credentials 
Expected Result – Sign in button should work

Test 3:
Verify Sign up account button works for valid credentials 
Expected Result – Sign up button should work for new account creation and we can verify this by logging into application

Test 4:
Verify search products by product name
Expected Result – Products should be displayed as per product name.

Test 5:
Verify search products by product description
Expected Result – Products should be displayed as per product description.

Test 6:
Verify place order and card information
Expected Result - Customer should be able to place order and card information should be recorded in the table.

Test 7:
Verify reorder funtionality, to maintain inventory accuracy in both store and warehouse.
Expected Result - Admit should be able reorder products that are low in store.