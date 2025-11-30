// Record Type
type Customer = {
    Name: string
    Age: int
}

// DU
type OrderStatus =
    | Pending
    | Shipped
    | Delivered
    | Cancelled

// Record Type
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
    { Customer = { Name = "Eve"; Age = 22 }; Status = Delivered; Amount = 300.0 }
]

let getPendingTotal orders =
    orders
    |> List.filter (fun o -> o.Status = Pending)
    |> List.map (fun o -> o.Amount)
    |> List.sum

printfn $"{getPendingTotal orders}"

