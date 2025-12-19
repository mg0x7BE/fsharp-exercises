(*
    Your Task:
    1. Write a function called multiplyPositive that:
       - Takes a list of integers
       - Uses the accumulator pattern
       - Multiplies ONLY the positive numbers together
       - Skips negative numbers and zero
       
       Structure:
       let multiplyPositive list =
           let rec loop acc remaining =
               match remaining with
               | [] -> acc
               | head :: tail ->
                   if ??? then  // Check if head is positive
                       loop ??? tail  // Multiply head with acc
                   else
                       loop ??? tail  // Skip, keep same acc
           loop ??? list  // What initial value for multiplication?
    
    2. Test with [2; -3; 4; 0; 5; -1]
    
    3. Print the result
    
    Expected output: 40
    (Only multiply: 2 * 4 * 5 = 40, skip -3, 0, -1)
*)