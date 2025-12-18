let products = ["Laptop"; "Mouse"; "Keyboard"; "Monitor"]
let prices = [999.99; 25.50; 75.00; 299.99]

let combined =
    List.zip products prices
    |> List.filter (fun (_, price) -> price > 50)
    |> List.map (fun (product,price) -> $"{product}: ${price:F2}")

printfn $"%A{combined}"