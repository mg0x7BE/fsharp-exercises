// 029.fsx

// Recursion with Accumulator Pattern
// We've used recursion before, but the accumulator pattern is more efficient.
// It uses tail recursion which doesn't risk stack overflow on large lists.

// Without accumulator (not tail-recursive, can overflow)
let rec sumSimple list =
    match list with
    | [] -> 0
    | head :: tail -> head + sumSimple tail
// Problem: Keeps stack frames until reaching []


// With accumulator (tail-recursive, safe)
let sumAccumulator list =
    let rec loop acc remaining =
        match remaining with
        | [] -> acc
        | head :: tail -> loop (acc + head) tail
    loop 0 list
// Better: Last operation is the recursive call (tail call)


// Example: Reverse a list with accumulator
let reverseList list =
    let rec loop acc remaining =
        match remaining with
        | [] -> acc
        | head :: tail -> loop (head :: acc) tail
    loop [] list

let reversed = reverseList [1; 2; 3; 4; 5]
// Result: [5; 4; 3; 2; 1]


// Example: Filter with accumulator
let filterPositive list =
    let rec loop acc remaining =
        match remaining with
        | [] -> List.rev acc  // Reverse to maintain order
        | head :: tail ->
            if head > 0 then
                loop (head :: acc) tail
            else
                loop acc tail
    loop [] list

let positive = filterPositive [-2; 3; -1; 5; 0; 7]
// Result: [3; 5; 7]


// Example: Count with accumulator
let countElements list =
    let rec loop count remaining =
        match remaining with
        | [] -> count
        | _ :: tail -> loop (count + 1) tail
    loop 0 list

let count = countElements [1; 2; 3; 4; 5]
// Result: 5


// Example: Find maximum with accumulator
let findMax list =
    match list with
    | [] -> None
    | head :: tail ->
        let rec loop currentMax remaining =
            match remaining with
            | [] -> currentMax
            | head :: tail ->
                let newMax = if head > currentMax then head else currentMax
                loop newMax tail
        Some (loop head tail)

let maxNum = findMax [3; 7; 2; 9; 1]
// Result: Some 9


(*
    Your Task:
    1. Write a function called sumSquares that:
       - Takes a list of integers
       - Uses the accumulator pattern (tail recursion)
       - Sums the squares of all numbers
       - Helper function should be named loop with parameters: acc and remaining

    2. Test it with [1; 2; 3; 4; 5]

    3. Print the result

    Expected output: 55
    (1² + 2² + 3² + 4² + 5² = 1 + 4 + 9 + 16 + 25 = 55)

    Hint: Structure should be:
    let sumSquares list =
        let rec loop acc remaining =
            match remaining with
            | [] -> acc
            | head :: tail -> loop (acc + head * head) tail
        loop 0 list
*)