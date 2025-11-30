let product list =
    List.fold (fun acc x -> acc * x) 1 list

printfn $"%A{product [2; 3; 4; 5]}"