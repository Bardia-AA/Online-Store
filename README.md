# Online Store: ASP.NET MVC, MSSQL Server, HTML, CSS, and JavaScript

## Overview
This repository contains an online store application developed using ASP.NET MVC, MSSQL Server, HTML, CSS, and JavaScript. It was created as a practice project to enhance full-stack web development skills. The application includes features such as product catalog management, shopping cart functionality, and order tracking.

## Features
- **Product Catalog Management**: Add, edit, and delete products within various categories.
- **Shopping Cart**: Add items to the cart, update quantities, and remove items.
- **Order Processing**: Create and manage customer orders.
- **Payment Integration**: Simulated payment processing and verification.
- **User Authentication**: Basic login and signup functionalities.

## Getting Started
### Prerequisites
- .NET Core SDK
- SQL Server
- Visual Studio or any compatible IDE

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/Bardia-AA/Online-Store.git
   ```
2. Navigate to the project directory:
   ```sh
   cd online-store
   ```
3. Set up the database:
   - Update the connection string in `appsettings.json` to match your SQL Server instance.
   - Run the following command to apply migrations and create the database:
     ```sh
     dotnet ef database update
     ```
4. Run the application:
   ```sh
   dotnet run
   ```

## Project Structure
- **Pillow.Core.Contracts**: Contains interface definitions for services and repositories.
- **Pillow.Core.Entities**: Contains entity classes representing the database models.
- **Pillow.Core.ApplicationService**: Contains service implementations for business logic.
- **Pillow.Infrastructure.Data**: Contains repository implementations for data access.
- **Pillow.Infrastructure.Sql**: Contains Entity Framework configurations and migrations.
- **PresentationHost**: Contains MVC controllers, views, and other presentation layer components.

## Database
The database schema is defined using Entity Framework Core migrations. Key tables include:
- **Products**: Stores product information such as name, description, price, and category.
- **Categories**: Stores product categories.
- **Orders**: Stores customer orders and their details.
- **CartLine**: Stores items within a shopping cart.

### Example SQL Queries
The application uses Entity Framework Core to interact with the database. Below are some example queries used in the application:

- **Retrieve Cheapest Products**:
  ```csharp
  public List<Product> GetCheapestProduct()
  {
      return productRepository.GetCheapestProduct().Take(4).ToList();
  }
  ```
- **Search Products**:
  ```csharp
  public (List<Product>, int) ProductSearch(string q, string category, int pageNumber, int pageSize)
  {
      return productRepository.GetFilterProducts(q, category, pageNumber, pageSize);
  }
  ```

## Key Classes and Interfaces
### Services
- **OrderService**: Manages order-related operations.
- **ProductService**: Manages product-related operations.

### Repositories
- **IOrderRepository**: Defines methods for order data access.
- **IProductRepository**: Defines methods for product data access.

### Entities
- **Order**: Represents a customer order.
- **Product**: Represents a product in the catalog.
- **Cart**: Represents a shopping cart.
- **Category**: Represents a product category.
- **Media**: Represents media files associated with products.

## Running the Application
To run the application, follow the installation steps mentioned above. Once the application is running, you can access it via the default URL (typically `https://localhost:5001` or `http://localhost:5000`).

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.
