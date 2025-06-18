# UML Diagrams for Food Ordering System

## 1. Use Case Diagram
```
```mermaid
graph TD;
  Client -->|Browse Menu| FoodOrderingSystem;
  Client -->|Place Order| FoodOrderingSystem;
  Client -->|View Order| FoodOrderingSystem;
  Client -->|Manage Account| FoodOrderingSystem;
  Administrator -->|Manage Categories| FoodOrderingSystem;
  Administrator -->|Manage Food Items| FoodOrderingSystem;
  Administrator -->|Manage Orders| FoodOrderingSystem;
  Administrator -->|Manage Users| FoodOrderingSystem;
  Administrator -->|View Reports| FoodOrderingSystem;
```
```

## 2. Class Diagram
```
```mermaid
classDiagram
    class Category {
      +id: int
      +title: String
      +image_name: String
      +featured: Enum
      +active: Enum
      +created_at: Timestamp
    }
    
    class Food {
      +id: int
      +title: String
      +description: Text
      +price: Decimal
      +image_name: String
      +active: Enum
      +created_at: Timestamp
    }
    
    class User {
      +id: int
      +username: String
      +password: String
      +created_at: Timestamp
    }
    
    class Order {
      +id: int
      +customer_name: String
      +customer_contact: String
      +customer_email: String
      +customer_address: Text
      +total: Decimal
      +order_date: Timestamp
      +status: String
    }
    
    class OrderItem {
      +id: int
      +quantity: Int
      +price: Decimal
    }
    
    Category --|> Food
    Order --|> OrderItem
    Food --|> OrderItem
    User --|> Order
```
```

## 3. Sequence Diagram (Order Process)
```
```mermaid
sequenceDiagram
    Client->>Frontend: Select food items
    Frontend->>Backend: Submit order (POST /orders)
    Backend->>Database: Create order record
    Backend->>Database: Create order items
    Database-->>Backend: Success response
    Backend-->>Frontend: Order confirmation
    Frontend-->>Client: Show confirmation page
```
```

## 4. Activity Diagram (Order Flow)
```
```mermaid
graph TD;
  A[Start] --> B[Browse Menu];
  B --> C[Add to Cart];
  C --> D[Checkout];
  D --> E[Enter Details];
  E --> F[Confirm Order];
  F --> G[Payment];
  G --> H[Order Complete];
  H --> I[End];
```
```

## 5. Component Diagram
```
```mermaid
graph TD;
    FE[Frontend] -->|HTTP Requests| BE[Backend];
    BE -->|SQL Queries| DB[Database];
    BE -->|API Calls| PG[Payment Gateway];
```
```

## 6. State Diagram (Order Status)
```
```mermaid
stateDiagram-v2
    [*] --> Ordered
    Ordered --> Preparing
    Preparing --> OnRoute
    OnRoute --> Delivered
    Ordered --> Cancelled
```
```

These UML diagrams provide a complete visual representation of your food ordering system, covering:

- **Functional Requirements** (Use Case Diagram)
- **Data Structure** (Class Diagram)
- **Process Flows** (Sequence & Activity Diagrams)
- **System Architecture** (Component Diagram)
- **State Management** (State Diagram)

You can generate these diagrams using [Mermaid.js](https://mermaid-js.github.io/).

