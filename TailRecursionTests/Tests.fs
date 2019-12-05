module Tests

open System
open FsUnit.Xunit
open Xunit

open TailRecursion.FibonacciDemo

let debugBreak () = 
    if not System.Diagnostics.Debugger.IsAttached then
      printfn "Please attach a debugger, PID: %d" (System.Diagnostics.Process.GetCurrentProcess().Id)
    while not System.Diagnostics.Debugger.IsAttached do
      System.Threading.Thread.Sleep(100)
    System.Diagnostics.Debugger.Break()

[<Fact>]
let ``fiboRec 30`` () =
    debugBreak ()
    30L |> fiboRec |> should equal 832040L

[<Fact>]
let ``fiboTailRec 2000`` () =
    debugBreak ()
    2000I |> fiboTailRec |> should equal 4224696333392304878706725602341482782579852840250681098010280137314308584370130707224123599639141511088446087538909603607640194711643596029271983312598737326253555802606991585915229492453904998722256795316982874482472992263901833716778060607011615497886719879858311468870876264597369086722884023654422295243347964480139515349562972087652656069529806499841977448720155612802665404554171717881930324025204312082516817125I
