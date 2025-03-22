namespace BeFaster.App.Solutions.DMO

open System
open System.Collections.Generic

type InventoryItem =
    { Id: string; Quantity: int } // Placeholder, adjust as needed

type DemoRound3Solution() =
    member _.InventoryAdd(item: InventoryItem, qty: int): unit =
        raise (NotImplementedException())

    member _.InventorySize(): int =
        raise (NotImplementedException())

    member _.InventoryGet(id: string): InventoryItem =
        raise (NotImplementedException())
