let mySeq = seq { 1 .. 50 }

let filtered =
    mySeq
    |> Seq.filter (fun x -> x % 3 = 0)
    |> Seq.map (fun x -> x * x)
    |> Seq.take 4
    |> Seq.toList

printfn $"%A{filtered}"


