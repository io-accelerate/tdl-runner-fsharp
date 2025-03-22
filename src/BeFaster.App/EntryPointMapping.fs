namespace BeFaster.App

open System.Collections.Generic
open TDL.Client.Queue.Abstractions
open BeFaster.App.Solutions.CHK
open BeFaster.App.Solutions.DMO
open BeFaster.App.Solutions.FIZ
open BeFaster.App.Solutions.HLO
open BeFaster.App.Solutions.SUM

/// <summary>
/// Maps RPC events to instance method calls with correctly typed parameters.
/// </summary>
type EntryPointMapping() =
    let sumSolution = SumSolution()
    let helloSolution = HelloSolution()
    let fizzBuzzSolution = FizzBuzzSolution()
    let checkoutSolution = CheckoutSolution()
    let demoRound1Solution = DemoRound1Solution()
    let demoRound2Solution = DemoRound2Solution()
    let demoRound3Solution = DemoRound3Solution()
    let demoRound4n5Solution = DemoRound4n5Solution()

    member _.Sum(p: List<ParamAccessor>) : obj =
        sumSolution.Sum(p.[0].GetAsInteger(), p.[1].GetAsInteger()) :> obj

    member _.Hello(p: List<ParamAccessor>) : obj =
        helloSolution.Hello(p.[0].GetAsString()) :> obj

    member _.FizzBuzz(p: List<ParamAccessor>) : obj =
        fizzBuzzSolution.FizzBuzz(p.[0].GetAsInteger()) :> obj

    member _.Checkout(p: List<ParamAccessor>) : obj =
        checkoutSolution.Checkout(p.[0].GetAsString()) :> obj

    // Demo Round 1
    member _.Increment(p: List<ParamAccessor>) : obj =
        demoRound1Solution.Increment(p.[0].GetAsInteger()) :> obj

    member _.ToUppercase(p: List<ParamAccessor>) : obj =
        demoRound1Solution.ToUppercase(p.[0].GetAsString()) :> obj

    member _.LetterToSanta(p: List<ParamAccessor>) : obj =
        demoRound1Solution.LetterToSanta() :> obj

    member _.CountLines(p: List<ParamAccessor>) : obj =
        demoRound1Solution.CountLines(p.[0].GetAsString()) :> obj

    // Demo Round 2
    member _.ArraySum(p: List<ParamAccessor>) : obj =
        demoRound2Solution.ArraySum(p.[0].GetAsListOf<int>()) :> obj

    member _.IntRange(p: List<ParamAccessor>) : obj =
        demoRound2Solution.IntRange(p.[0].GetAsInteger(), p.[1].GetAsInteger()) :> obj

    member _.FilterPass(p: List<ParamAccessor>) : obj =
        demoRound2Solution.FilterPass(p.[0].GetAsListOf<int>(), p.[1].GetAsInteger()) :> obj

    // Demo Round 3
    member _.InventoryAdd(p: List<ParamAccessor>) : obj =
        demoRound3Solution.InventoryAdd(p.[0].GetAsObject<InventoryItem>(), p.[1].GetAsInteger()) :> obj

    member _.InventorySize(p: List<ParamAccessor>) : obj =
        demoRound3Solution.InventorySize() :> obj

    member _.InventoryGet(p: List<ParamAccessor>) : obj =
        demoRound3Solution.InventoryGet(p.[0].GetAsString()) :> obj

    // Demo Round 4 and 5
    member _.Waves(p: List<ParamAccessor>) : obj =
        demoRound4n5Solution.Waves(p.[0].GetAsInteger()) :> obj
