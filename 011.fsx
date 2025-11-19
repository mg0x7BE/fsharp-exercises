// 011.fsx

// Option Recap
// Option represents "maybe has a value": Some value or None

let safeDivide x y =
    if y = 0 then None
    else Some (x / y)

// Pattern matching on Option
let describe opt =
    match opt with
    | Some value -> $"Result: {value}"
    | None -> "Error: division by zero"


// Option.map - transform the value inside Some
let doubled = Option.map (fun x -> x * 2) (Some 5)  // Some 10


// Option.defaultValue - extract value or use default
let value = Option.defaultValue 0 (safeDivide 10 0)  // 0


(*
    Your Task:
    1. Write a function findLast that:
       - Takes a predicate function (int -> bool)
       - Takes a list of integers
       - Returns Some (last element matching predicate) or None if not found
       - Use recursion and pattern matching
    
    2. Test it with:
       - Finding last even number in [1; 2; 3; 4; 5; 6]
       - Finding last number > 100 in [10; 20; 30]
    
    3. Print both results with pattern matching.
    
    Expected output:
    - Last even: 6
    - Last > 100: Not found
    
    Hint: You need to search the ENTIRE list, not stop at first match!
*)