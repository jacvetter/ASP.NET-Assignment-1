Assignment 1
Author: Abby Vetter
Course: ASP.NET T0510-2
Date: April 2025


To run the program:
1) Unzip the solution folder
2) Open the solution in Visual Studio
3) Run the project by using the terminal/button at the top/f5
4) Add "/swagger" to the end of the opened url
5) To use Swagger, open the drop down of your chosen function
6) Then click "Try it out" and fill it out as follows:


The different options explained:

	POST/api/products
	-This request posts a new product in the temp database.
	-There is no need to do anything with the id, just change the strings and price
		then select "Execute".
	-JSON is formatted like this:
		{
  	"id": 0,
  	"name": "string",
  	"description": "string",
  	"price": 0
  	}


	GET/api/products
	-This request replies with all of the products currently stored in the temp database.
	-Simply click "Try it out" then click "Execute", there is no need to add anything.


	GET/api/products/{id}
	-This request replies with the data from the product with the input id.
	-Simply input the product id of your choice and hit "Execute"

	DELETE/api/products/{id}
	-This request deletes a product from the temp database.
	-Type in the id of the product you'd like to delete and hit "Execute"
