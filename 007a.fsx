let result =
    [2; 3; 4]
    |> List.map (fun x -> [1 .. x])
    |> List.collect (fun x -> x)
    |> List.filter (fun x -> x % 2 = 0)
    
printfn $"%A{result}"