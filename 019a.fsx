// 019.fsx

// Combining Everything: Records, DUs, Options, and Lists
// Let's practice using multiple concepts together.

type Customer = {
    Name: string
    Age: int
}

type OrderStatus =
    | Pending
    | Shipped
    | Delivered
    | Cancelled

type Order = {
    Customer: Customer
    Status: OrderStatus
    Amount: float
}

// Example data
let orders = [
    { Customer = { Name = "Alice"; Age = 30 }; Status = Delivered; Amount = 150.0 }
    { Customer = { Name = "Bob"; Age = 25 }; Status = Pending; Amount = 200.0 }
    { Customer = { Name = "Carol"; Age = 35 }; Status = Shipped; Amount = 75.0 }
    { Customer = { Name = "Dave"; Age = 28 }; Status = Cancelled; Amount = 120.0 }
    { Customer = { Name = "Eve"; Age = 22 }; Status = Delivered; Amount = 300.0 }
]


// Example: Filter delivered orders
let deliveredOrders =
    orders
    |> List.filter (fun o -> o.Status = Delivered)

// Example: Get total amount of delivered orders
let deliveredTotal =
    deliveredOrders
    |> List.map (fun o -> o.Amount)
    |> List.sum


// Example: Find customer with highest order
let findBiggestOrder orders =
    match orders with
    | [] -> None
    | _ ->
        let maxOrder = List.reduce (fun acc o -> if o.Amount > acc.Amount then o else acc) orders
        Some maxOrder.Customer.Name


(*
    Your Task:
    1. Write a function called getPendingTotal that:
       - Takes a list of orders
       - Filters to keep only Pending orders
       - Calculates the total amount of pending orders
       - Returns the total as a float

    2. Test it with the orders list above

    3. Print the result

    Expected output: 200.0
    (Only Bob's order is Pending with Amount = 200.0)
*)