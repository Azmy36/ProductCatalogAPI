# Assignment 2 - ASP.NET Core Web API

A RESTful Web API built with ASP.NET Core 8.0, demonstrating clean architecture with Models, Controllers, Interfaces, and Services. This project implements a simple e-commerce API for managing Products and Categories.

## 🚀 Features

- **2 Models**: Product and Category
- **2 Controllers**: Each with 3 RESTful endpoints (GET all, GET by id, POST create)
- **Dependency Injection**: Using interfaces and services
- **Swagger Documentation**: Interactive API testing with Swagger UI
- **CORS Enabled**: Ready for frontend integration
- **In-Memory Storage**: Simple data persistence during runtime

## 📁 Project Structure

```
Assignment2App/
├── Controllers/          # API Controllers
│   ├── ProductsController.cs    (3 endpoints)
│   └── CategoriesController.cs  (3 endpoints)
├── Models/              # Data Models
│   ├── Product.cs
│   └── Category.cs
├── Interfaces/          # Service Interfaces
│   ├── IProductService.cs
│   └── ICategoryService.cs
├── Services/            # Service Implementations
│   ├── ProductService.cs
│   └── CategoryService.cs
├── Program.cs           # Application entry point & configuration
├── Properties/
│   └── launchSettings.json
├── appsettings.json
└── README.md
```

## 📋 Models

### Product
- `Id` (int) - Auto-generated unique identifier
- `Name` (string) - Product name
- `Price` (decimal) - Product price
- `CategoryId` (int) - Foreign key to Category

### Category
- `Id` (int) - Auto-generated unique identifier
- `Name` (string) - Category name
- `Description` (string?) - Optional category description

## 🔌 API Endpoints

### ProductsController (`/api/products`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/products` | Get all products |
| GET | `/api/products/{id}` | Get product by id |
| POST | `/api/products` | Create new product |

**Example POST Request:**
```json
{
  "name": "Laptop",
  "price": 999.99,
  "categoryId": 1
}
```

### CategoriesController (`/api/categories`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/categories` | Get all categories |
| GET | `/api/categories/{id}` | Get category by id |
| POST | `/api/categories` | Create new category |

**Example POST Request:**
```json
{
  "name": "Electronics",
  "description": "Electronic devices and gadgets"
}
```

## 🛠️ Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Git (for cloning)

## 🏃 Running the Project

1. **Clone the repository**
   ```bash
   git clone <your-repo-url>
   cd Assignment-2
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Open Swagger UI**
   - Navigate to: `http://localhost:5000/swagger`
   - Or: `https://localhost:5001/swagger`

## 🧪 Testing with Swagger

Swagger UI provides an interactive interface to test all endpoints:

1. Open `http://localhost:5000/swagger` in your browser
2. Expand any endpoint section (Products or Categories)
3. Click **"Try it out"**
4. Fill in the request body (for POST requests)
5. Click **"Execute"**
6. View the response below

## 📝 Example API Calls

### Create a Category
```bash
curl -X POST "http://localhost:5000/api/categories" \
  -H "Content-Type: application/json" \
  -d '{"name":"Electronics","description":"Electronic devices"}'
```

### Get All Categories
```bash
curl "http://localhost:5000/api/categories"
```

### Create a Product
```bash
curl -X POST "http://localhost:5000/api/products" \
  -H "Content-Type: application/json" \
  -d '{"name":"Laptop","price":999.99,"categoryId":1}'
```

## 🏗️ Architecture

- **Models**: Data entities (Product, Category)
- **Interfaces**: Service contracts (IProductService, ICategoryService)
- **Services**: Business logic implementation (ProductService, CategoryService)
- **Controllers**: API endpoints handling HTTP requests/responses
- **Dependency Injection**: Services registered in `Program.cs`

## 📦 Technologies Used

- ASP.NET Core 8.0
- Swashbuckle.AspNetCore (Swagger)
- C# 12
- RESTful API Design

## 📄 License

This project is created for educational purposes as part of Assignment 2.

## 👤 Author

Created as part of Web Development Assignment 2.

---

**Note**: Data is stored in-memory and will be lost when the application stops. For persistent storage, consider adding Entity Framework Core with a database.
