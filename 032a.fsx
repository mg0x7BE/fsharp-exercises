type Student = {
    Name: string
    Grade: int
    Subject: string
}

let students = [
    { Name = "Alice"; Grade = 85; Subject = "Math" }
    { Name = "Bob"; Grade = 92; Subject = "Physics" }
    { Name = "Carol"; Grade = 78; Subject = "Math" }
    { Name = "Dave"; Grade = 88; Subject = "Physics" }
    { Name = "Eve"; Grade = 95; Subject = "Math" }
]

let subjects =
    students |> List.groupBy (fun p -> p.Subject)

let avgGrades =
    subjects
    |> List.map (fun (subject, studentsList) ->
        let total = List.sumBy (fun s -> s.Grade) studentsList
        let count = List.length studentsList
        (subject, float total / float count))

printfn $"%A{subjects}"

printfn $"%A{avgGrades}"
