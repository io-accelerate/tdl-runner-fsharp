namespace BeFaster.App.Solutions.DMO

open System
open BeFaster.App.Solutions.DMO

type DemoRound3Solution() =
    member _.InventoryAdd(item: InventoryItem, qty: int): unit =
        raise (NotImplementedException())

    member _.InventorySize(): int =
        raise (NotImplementedException())

    member _.InventoryGet(id: string): InventoryItem =
        raise (NotImplementedException())
