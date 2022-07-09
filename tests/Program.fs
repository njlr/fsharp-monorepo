open Expecto
open MathUtils

let tests =
  testList "MathUtils" [
    test "add works for simple cases" {
      Expect.equal (add 1 2) 3 ""
      Expect.equal (add 1 1) 2 ""
      Expect.equal (add 3 4) 7 ""
    }
  ]

[<EntryPoint>]
let main args =
  runTestsWithCLIArgs [] args tests
