namespace BeFaster.App.Solutions.HLO

open System

type HelloSolution() =
    member _.Hello(friendName: string): string =
        raise (NotImplementedException())
