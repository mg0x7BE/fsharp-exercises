let extractPositive (i: int) =
    match i with
    | i when (i > 0) -> Some i
    | _ -> None
    
let results = List.choose extractPositive [-5; 10; -3; 0; 7; -1; 15]
 
printfn $"{results}"   
   