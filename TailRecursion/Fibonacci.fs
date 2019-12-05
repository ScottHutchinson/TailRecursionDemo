namespace TailRecursion

module FibonacciDemo =

    // From https://gist.github.com/rflechner/2b59e81381bc59306dff9cc4147d4f18

    let rec fiboRec =
      function
      | 0L -> 0L
      | 1L -> 1L
      | n -> fiboRec (n - 1L) + fiboRec (n - 2L)

    let fiboTailRec n =
      let rec loop (n1, n2) i =
        if i < n
        then loop (n1 + n2, n1) (i + 1I)
        else n1
      loop (0I, 1I) 0I

    let inline calcFibSequence start finish f =
        for i in start..finish do
          printfn "fiboRec of %A => %A" i (f i)

    // fiboRec 30L
    // fiboTailRec 2000I

    // calcFibSequence 0L 40L fiboRec
    // calcFibSequence 0I 40I fiboTailRec
