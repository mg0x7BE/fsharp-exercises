let list = [1; 2; 3; 4; 5]

let multiply x y = x * y

let triple = multiply 3

let result =
    list
    |> List.map triple
    
printfn $"Result: %A{result}"