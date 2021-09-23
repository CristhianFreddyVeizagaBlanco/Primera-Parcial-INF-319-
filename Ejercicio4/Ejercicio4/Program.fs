// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

[<EntryPoint>]
let main argv = 
    printfn "Cristhian Freddy Veizaga Blanco"

    let lista = [1; 2; 3; 4; 10; 9; 8]
    let listapares = []
    let listaimpares = []
    printfn "Lista original: %A" lista
    let listapares = List.filter (fun x-> x % 2 = 0) lista
    let listaimpares = List.filter (fun x-> x % 2 = 1) lista
    printf ""
    printfn "Lista de Pares: %A" listapares
    printf ""
    printfn "Lista de Impares: %A" listaimpares




    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero