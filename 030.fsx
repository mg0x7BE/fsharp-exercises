// 030.fsx

// Combining Everything: Real-World Data Processing
// This lesson combines all major concepts you've learned.
// We'll process a realistic dataset using multiple techniques.

type OrderStatus =
    | Pending
    | Shipped
    | Delivered
    | Cancelled

type Customer = {
    Id: int
    Name: string
    Email: string
}

type Order = {
    Id: int
    Customer: Customer
    Status: OrderStatus
    Amount: float
    Items: string list
}

// Sample data
let orders = [
    { Id = 1; Customer = { Id = 101; Name = "Alice"; Email = "alice@example.com" }; 
      Status = Delivered; Amount = 150.50; Items = ["Laptop Case"; "Mouse"] }
    { Id = 2; Customer = { Id = 102; Name = "Bob"; Email = "bob@example.com" }; 
      Status = Pending; Amount = 299.99; Items = ["Keyboard"; "Monitor Stand"; "USB Cable"] }
    { Id = 3; Customer = { Id = 101; Name = "Alice"; Email = "alice@example.com" }; 
      Status = Delivered; Amount = 75.00; Items = ["Mouse Pad"] }
    { Id = 4; Customer = { Id = 103; Name = "Carol"; Email = "carol@example.com" }; 
      Status = Cancelled; Amount = 500.00; Items = ["Laptop"; "Charger"] }
    { Id = 5; Customer = { Id = 102; Name = "Bob"; Email = "bob@example.com" }; 
      Status = Shipped; Amount = 125.75; Items = ["Headphones"] }
    { Id = 6; Customer = { Id = 104; Name = "Dave"; Email = "dave@example.com" }; 
      Status = Delivered; Amount = 89.99; Items = ["Webcam"; "Microphone"] }
]


// Example 1: Get all delivered orders, sorted by amount
let deliveredOrders = 
    orders
    |> List.filter (fun o -> o.Status = Delivered)
    |> List.sortByDescending (fun o -> o.Amount)

// Example 2: Total revenue from delivered orders
let deliveredRevenue = 
    orders
    |> List.filter (fun o -> o.Status = Delivered)
    |> List.map (fun o -> o.Amount)
    |> List.sum

// Example 3: Group orders by customer name, count orders per customer
let ordersByCustomer = 
    orders
    |> List.groupBy (fun o -> o.Customer.Name)
    |> List.map (fun (name, orders) -> (name, List.length orders))
    |> List.sortByDescending snd  // Sort by order count

// Example 4: Get all unique items ordered
let allItems = 
    orders
    |> List.collect (fun o -> o.Items)
    |> List.distinct
    |> List.sortBy id

// Example 5: Find customer with highest total spending
let customerSpending = 
    orders
    |> List.filter (fun o -> o.Status <> Cancelled)  // Exclude cancelled
    |> List.groupBy (fun o -> o.Customer.Name)
    |> List.map (fun (name, orders) -> 
        let total = orders |> List.map (fun o -> o.Amount) |> List.sum
        (name, total))
    |> List.sortByDescending snd
    |> List.head  // Get top spender

// Example 6: Orders by status with counts
let orderStatusSummary = 
    orders
    |> List.groupBy (fun o -> o.Status)
    |> List.map (fun (status, orders) -> (status, List.length orders))


(*
    Your Task - Mini Analysis:
    
    1. Calculate the average order amount for ONLY Delivered and Shipped orders
       (exclude Pending and Cancelled)
       
       Steps:
       - Filter orders to keep only Delivered or Shipped
       - Extract amounts using List.map
       - Calculate average: (sum / count)
       - Hint: Convert to float for division
    
    2. Find all customers who have placed more than 1 order
       
       Steps:
       - Group orders by Customer.Id (not Name, to handle duplicates properly)
       - Filter groups where order count > 1
       - Extract customer names from the groups
       - Hint: Use List.choose or List.filter + List.map
    
    3. Print both results in format:
       "Average order value (Delivered/Shipped): ${amount:F2}"
       "Customers with multiple orders: [names]"
    
    Expected output:
    - Average order value (Delivered/Shipped): $110.31
      (150.50 + 75.00 + 125.75 + 89.99) / 4 = 110.31
    - Customers with multiple orders: ["Alice"; "Bob"]
*)