// 035-project-todo-list.fsx

// PROJECT: TODO List Manager (CLI)
// Build a simple command-line TODO list application.
// Users can add tasks, mark them as complete, list tasks, and remove tasks.

// YOUR TASKS:

// Part 1: Data Modeling
// 1. Create a Discriminated Union for TaskStatus:
//    - Pending
//    - Completed
//
// 2. Create a record type Task with fields:
//    - Id: int
//    - Description: string
//    - Status: TaskStatus
//
// 3. Create a type alias TodoList for a list of Task


// Part 2: Core Functions
// 4. Write a function addTask that:
//    - Takes: description (string), current todo list
//    - Generates new ID (use: (List.length list) + 1)
//    - Creates new task with status Pending
//    - Returns: new todo list with added task
//
// 5. Write a function completeTask that:
//    - Takes: task ID, current todo list
//    - Finds task with matching ID
//    - Updates its status to Completed
//    - Returns: updated todo list
//    - Hint: Use List.map and check if task.Id matches
//
// 6. Write a function removeTask that:
//    - Takes: task ID, current todo list
//    - Removes task with matching ID
//    - Returns: new todo list without that task
//    - Hint: Use List.filter
//
// 7. Write a function listTasks that:
//    - Takes: todo list
//    - Groups tasks by status (Pending vs Completed)
//    - Returns formatted string showing all tasks
//    - Format:
//      PENDING TASKS:
//      [1] Buy groceries
//      [2] Finish project
//
//      COMPLETED TASKS:
//      [3] Call dentist


// Part 3: Helper Functions
// 8. Write a function formatTask that:
//    - Takes: a Task
//    - Returns: formatted string "[ID] Description"
//
// 9. Write a function countByStatus that:
//    - Takes: todo list and status
//    - Returns: count of tasks with that status
//    - Hint: Use List.filter and List.length


// Part 4: Put It All Together
// 10. Create an initial empty todo list
// 11. Add several tasks (at least 4)
// 12. Complete some tasks (at least 2)
// 13. Remove one task
// 14. Print the final state using listTasks
// 15. Print statistics:
//     - Total tasks: X
//     - Pending: X
//     - Completed: X


// EXAMPLE WORKFLOW:
(*
let todos = []
let todos = addTask "Buy groceries" todos
let todos = addTask "Call dentist" todos
let todos = addTask "Finish project" todos
let todos = addTask "Clean room" todos
let todos = completeTask 2 todos  // Complete "Call dentist"
let todos = completeTask 4 todos  // Complete "Clean room"
let todos = removeTask 3 todos    // Remove "Finish project"

printfn "%s" (listTasks todos)
printfn "\nStatistics:"
printfn "Total tasks: %d" (List.length todos)
printfn "Pending: %d" (countByStatus todos Pending)
printfn "Completed: %d" (countByStatus todos Completed)
*)


// EXPECTED OUTPUT (example):
(*
PENDING TASKS:
[1] Buy groceries

COMPLETED TASKS:
[2] Call dentist
[4] Clean room

Statistics:
Total tasks: 3
Pending: 1
Completed: 2
*)


// HINTS:
// - To update a task in a list, use List.map with an if check
// - To create new list with updated task:
//   list |> List.map (fun t -> if t.Id = targetId then { t with Status = Completed } else t)
// - To partition by status: List.partition (fun t -> t.Status = Pending)
// - String.concat "\n" joins strings with newlines
