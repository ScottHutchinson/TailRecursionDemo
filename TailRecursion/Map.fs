namespace TailRecursion

module MapDemo =

    // From https://stackoverflow.com/questions/3248091/f-tail-recursive-function-example/3248477#3248477

    let rec mapSO f = function
        | [] -> []
        | x::xs -> f x::mapSO f xs

    let mapTR f l =
        let rec loop acc = function
            | [] -> List.rev acc
            | x::xs -> loop (f x::acc) xs
        loop [] l

    let mapCP f l =
        let rec loop cont = function
            | [] -> cont []
            | x::xs -> loop ( fun acc -> cont (f x::acc) ) xs
        loop id l

    let square x = x * x

    let inputs = [1..10]

    // inputs |> List.map square

    // inputs |> mapSO square
    // inputs |> mapTR square
    // inputs |> mapCP square
