open TDL.Client
open TDL.Client.Runner
open BeFaster.App
open BeFaster.App.Solutions.CHK
open BeFaster.App.Solutions.FIZ
open BeFaster.App.Solutions.HLO
open BeFaster.App.Solutions.SUM
open BeFaster.Runner
open BeFaster.Runner.Utils
open Newtonsoft.Json.Linq;
open System

/// <summary>
/// ~~~~~~~~~~ Running the system: ~~~~~~~~~~~~~
///
///   From IDE:
///      Configure the "BeFaster.App" solution to Run on External Console then run.
///
///   From command line:
///      dotnet run --project src\BeFaster.App
///
///   To run your unit tests locally:
///      Run the "BeFaster.App.Tests" project.
///      or
///      dotnet test
///
/// ~~~~~~~~~~ The workflow ~~~~~~~~~~~~~
///
///   By running this file you interact with a challenge server.
///   The interaction follows a request-response pattern:
///        * You are presented with your current progress and a list of actions.
///        * You trigger one of the actions by typing it on the console.
///        * After the action feedback is presented, the execution will stop.
///
///   +------+-----------------------------------------------------------------------+
///   | Step | The usual workflow                                                    |
///   +------+-----------------------------------------------------------------------+
///   |  1.  | Run this file.                                                        |
///   |  2.  | Start a challenge by typing "start".                                  |
///   |  3.  | Read the description from the "challenges" folder.                    |
///   |  4.  | Locate the file corresponding to your current challenge in:           |
///   |      |   src\BeFaster.App\Solutions                                          |
///   |  5.  | Replace the following placeholder exception with your solution:       |
///   |      |   raise (NotImplementedException())                                   |
///   |  6.  | Deploy to production by typing "deploy".                              |
///   |  7.  | Observe the output, check for failed requests.                        |
///   |  8.  | If passed, go to step 1.                                              |
///   +------+-----------------------------------------------------------------------+
///
///   You are encouraged to change this project as you please:
///        * You can use your preferred libraries.
///        * You can use your own test framework.
///        * You can change the file structure.
///        * Anything really, provided that this file stays runnable.
///
/// </summary>
[<EntryPoint>]
let main argv = 
    let mapping = EntryPointMapping()

    let runner =
        QueueBasedImplementationRunner.Builder()
            .SetConfig(Utils.Utils.GetRunnerConfig())
            .WithSolutionFor("sum", fun p -> mapping.Sum(p))
            .WithSolutionFor("hello", fun p -> mapping.Hello(p))
            .WithSolutionFor("fizz_buzz", fun p -> mapping.FizzBuzz(p))
            .WithSolutionFor("checkout", fun p -> mapping.Checkout(p))
            .WithSolutionFor("rabbit_hole", fun p -> mapping.RabbitHole(p))
            .WithSolutionFor("render_house", fun p -> mapping.RenderHouse(p))
            .WithSolutionFor("amazing_maze", fun p -> mapping.AmazingMaze(p))
            .WithSolutionFor("ultimate_maze", fun p -> mapping.UltimateMaze(p))
            .WithSolutionFor("increment", fun p -> mapping.Increment(p))
            .WithSolutionFor("to_uppercase", fun p -> mapping.ToUppercase(p))
            .WithSolutionFor("letter_to_santa", fun p -> mapping.LetterToSanta(p))
            .WithSolutionFor("count_lines", fun p -> mapping.CountLines(p))
            .WithSolutionFor("array_sum", fun p -> mapping.ArraySum(p))
            .WithSolutionFor("int_range", fun p -> mapping.IntRange(p))
            .WithSolutionFor("filter_pass", fun p -> mapping.FilterPass(p))
            .WithSolutionFor("inventory_add", fun p -> mapping.InventoryAdd(p))
            .WithSolutionFor("inventory_size", fun p -> mapping.InventorySize(p))
            .WithSolutionFor("inventory_get", fun p -> mapping.InventoryGet(p))
            .WithSolutionFor("waves", fun p -> mapping.Waves(p))
            .Create()

    ChallengeSession.ForRunner(runner)
        .WithConfig(Utils.GetConfig())
        .WithActionProvider(new UserInputAction(argv))
        .Start()

    if not Console.IsInputRedirected then
        printfn "Press any key to exit..."
        Console.ReadKey() |> ignore
    
    0 // return an integer exit code
