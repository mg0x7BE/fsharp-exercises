// 018.fsx

// List.reduce
// List.reduce is like List.fold, but uses the first element as the initial value.
// It requires a non-empty list (throws exception on empty list).
// Syntax: List.reduce (fun acc element -> newAcc) list

// Example: Sum with reduce
let numbers = [1; 2; 3; 4; 5]
let sum = List.reduce (fun acc x -> acc + x) numbers  // 15

// Same as:
// let sum = List.fold (fun acc x -> acc + x) 0 numbers


// Example: Find maximum
let maxNum = List.reduce (fun acc x -> if x > acc then x else acc) [3; 7; 2; 9; 1]
// Step by step:
// acc=3 (first element), x=7 -> 7 > 3? YES -> acc=7
// acc=7, x=2 -> 2 > 7? NO -> acc=7
// acc=7, x=9 -> 9 > 7? YES -> acc=9
// acc=9, x=1 -> 1 > 9? NO -> acc=9
// Result: 9


// Example: Concatenate strings
let words = ["Hello"; "world"; "from"; "F#"]
let sentence = List.reduce (fun acc word -> acc + " " + word) words
// Result: "Hello world from F#"


// Difference: fold vs reduce
let foldSum = List.fold (+) 0 [1; 2; 3]     // Works on empty list -> 0
let reduceSum = List.reduce (+) [1; 2; 3]   // Throws on empty list!

// Note: (+) is shorthand for (fun a b -> a + b)


(*
    Your Task:
    1. Write a function called findMinimum that:
       - Takes a list of integers
       - Uses List.reduce to find the smallest number
       - Returns the minimum value

    2. Test it with [8; 3; 12; 1; 7; 5]

    3. Print the result

    Expected output: 1

    Hint: Use similar logic to the maximum example, but reverse the condition.
*)