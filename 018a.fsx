let findMinimum list =
    List.reduce (fun acc x -> if acc < x then acc else x) list

printfn $"%A{findMinimum [8; 3; 12; 1; 7; 5]}"