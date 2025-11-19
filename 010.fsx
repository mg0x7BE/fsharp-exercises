// 010.fsx

// Option Type
// F# doesn't have null by default. Instead, we use Option to represent "maybe has a value".
// Option can be:
//   - Some value (has a value)
//   - None (no value)

let someNumber = Some 42
let noNumber = None

// Pattern matching on Option
let describe opt =
    match opt with
    | Some value -> $"Got value: {value}"
    | None -> "No value"

let result1 = describe someNumber  // "Got value: 42"
let result2 = describe noNumber    // "No value"


// Practical example: Safe division
let safeDivide x y =
    if y = 0 then
        None  // Can't divide by zero
    else
        Some (x / y)

let result3 = safeDivide 10 2  // Some 5
let result4 = safeDivide 10 0  // None


// Option.map
// Apply a function to the value inside Some, or do nothing if None
let doubled = Option.map (fun x -> x * 2) (Some 5)  // Some 10
let nothing = Option.map (fun x -> x * 2) None      // None


// Option.bind (flatMap)
// Use when your function returns an Option
let result5 = 
    safeDivide 20 2
    |> Option.bind (fun x -> safeDivide x 2)  // Some 5 (20 / 2 / 2)

let result6 = 
    safeDivide 20 0
    |> Option.bind (fun x -> safeDivide x 2)  // None (first division failed)


// Option.defaultValue
// Extract value or use default
let value1 = Option.defaultValue 0 (Some 42)  // 42
let value2 = Option.defaultValue 0 None       // 0


(*
    Your Task:
    1. Write a function findFirst that:
       - Takes a predicate function (int -> bool)
       - Takes a list of integers
       - Returns Some (first element matching predicate) or None if not found
       - Use recursion and pattern matching (don't use List.tryFind)
    
    2. Test it with:
       - Finding first even number in [1; 3; 5; 8; 9; 10]
       - Finding first number > 100 in [1; 50; 75; 90]
    
    3. Print both results using pattern matching to show either the value or "Not found".
    
    Expected output:
    - First even: 8
    - First > 100: Not found
*)