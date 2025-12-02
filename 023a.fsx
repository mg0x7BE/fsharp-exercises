type Person = {
    Name: string
    Age: int
}

let people = [
    { Name = "Alice"; Age = 30 }
    { Name = "Bob"; Age = 25 }
    { Name = "Carol"; Age = 35 }
    { Name = "Dave"; Age = 25 }
    { Name = "Eve"; Age = 28 }
]

let boomers =
    people
    |> List.filter (fun x -> x.Age >= 25)
    |> List.sortByDescending (fun x -> x.Age)
    |> List.take 3
    |> List.map (fun p -> p.Name)

printfn $"%A{boomers}"