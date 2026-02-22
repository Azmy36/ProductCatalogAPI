ProductCatalogAPI

A RESTful Web API built with ASP.NET Core 8.0, demonstrating clean architecture using Models, Controllers, Interfaces, and Services.

This project implements a simple e-commerce Product Catalog API for managing Products and Categories using in-memory storage.

Features

2 Models: Product and Category

2 Controllers with 3 RESTful endpoints each (GET all, GET by id, POST create)

Dependency Injection using interfaces and services

Swagger documentation for interactive API testing

CORS enabled for frontend integration

In-memory storage for runtime data persistence

Clean and structured architecture

Project Structure
ProductCatalogAPI/
├── Controllers/
│   ├── ProductsController.cs
│   └── CategoriesController.cs
├── Models/
│   ├── Product.cs
│   └── Category.cs
├── Interfaces/
│   ├── IProductService.cs
│   └── ICategoryService.cs
├── Services/
│   ├── ProductService.cs
│   └── CategoryService.cs
├── Program.cs
├── Properties/
│   └── launchSettings.json
├── appsettings.json
└── README.md
Models
Product

Id (int) – Auto-generated unique identifier

Name (string) – Product name

Price (decimal) – Product price

CategoryId (int) – Foreign key reference to Category

Category

Id (int) – Auto-generated unique identifier

Name (string) – Category name

Description (string?) – Optional category description

API Endpoints
ProductsController (/api/products)
Method	Endpoint	Description
GET	/api/products	Retrieve all products
GET	/api/products/{id}	Retrieve product by ID
POST	/api/products	Create a new product

Example POST Request:

{
  "name": "Laptop",
  "price": 999.99,
  "categoryId": 1
}
CategoriesController (/api/categories)
Method	Endpoint	Description
GET	/api/categories	Retrieve all categories
GET	/api/categories/{id}	Retrieve category by ID
POST	/api/categories	Create a new category

Example POST Request:

{
  "name": "Electronics",
  "description": "Electronic devices and gadgets"
}
Prerequisites

.NET 8.0 SDK or later

Git

Running the Project

Clone the repository:

git clone <your-repo-url>
cd ProductCatalogAPI

Restore dependencies:

dotnet restore

Run the application:

dotnet run

Open Swagger UI:

http://localhost:5000/swagger

https://localhost:5001/swagger

Testing with Swagger

Open /swagger in your browser.

Expand Products or Categories.

Click "Try it out".

Enter the request body for POST requests.

Click "Execute".

Review the response.

Example API Calls

Create a Category:

curl -X POST "http://localhost:5000/api/categories" \
  -H "Content-Type: application/json" \
  -d '{"name":"Electronics","description":"Electronic devices"}'

Get All Categories:

curl "http://localhost:5000/api/categories"

Create a Product:

curl -X POST "http://localhost:5000/api/products" \
  -H "Content-Type: application/json" \
  -d '{"name":"Laptop","price":999.99,"categoryId":1}'
Architecture Overview

Models: Data entities

Interfaces: Service contracts

Services: Business logic implementation

Controllers: HTTP request handling

Dependency Injection: Registered in Program.cs

This structure ensures clean separation of concerns and scalability.

Technologies Used

ASP.NET Core 8.0

Swashbuckle.AspNetCore (Swagger)

C# 12

RESTful API Design

Author

Youssef Azmy

Note

Data is stored in-memory and will be lost when the application stops.

For persistent storage, consider integrating Entity Framework Core with a relational database such as SQL Server or PostgreSQL.
