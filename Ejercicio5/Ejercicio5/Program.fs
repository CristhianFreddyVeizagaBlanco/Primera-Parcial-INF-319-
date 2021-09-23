// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

[<EntryPoint>]
let main argv = 
    printfn "Cristhian"

    let a=7
    let b=6
    let mutable res = 0
    for i = 1 to a do
       printfn "= %i" res
       res <- res + b
    printfn "= %i" res
    printfn "7*6 Con sumas es = %i" res
    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
