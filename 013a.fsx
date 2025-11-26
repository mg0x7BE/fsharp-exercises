let describePerson person =
    match person with
    | (name, age) when age < 18 -> $"Child: {name}"
    | (name, age) when age >= 18 && age < 65 -> $"Adult: {name}"
    | (name, age) when age >= 65 -> $"Senior: {name}"
    | _ -> "Unknown"    

describePerson ("Alice", 10)
describePerson ("Bob", 35)
describePerson ("Carol", 70)