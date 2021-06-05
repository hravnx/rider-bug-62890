open System

module Array =
    let doStuff (xs : int[]) =
        xs
        |> Array.map (fun x -> (x*2).ToString())
        |> Array.map Int32.Parse
        |> Array.filter (fun x -> x % 3 = 0)

[<EntryPoint>]
let main _argv =
    let result = [| 1; 2; 3 |] |> Array.doStuff

    printfn "Result %A" result

    0