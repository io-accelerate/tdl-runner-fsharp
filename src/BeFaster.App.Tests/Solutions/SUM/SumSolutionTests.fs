namespace BeFaster.App.Tests

open NUnit.Framework
open BeFaster.App.Solutions.SUM

[<TestFixture>]
type SumSolutionTests() =

    [<Test>]
    member x.``2 + 3 = 5``() =
        let solution = SumSolution()
        Assert.AreEqual(5, solution.Sum(2, 3))
