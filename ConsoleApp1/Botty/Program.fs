open System.Threading.Tasks
open Lexi.Botty.BottyMain
[<EntryPoint>]
let main argv = 
    discord.ConnectAsync() |> Async.AwaitTask |> Async.RunSynchronously
    Task.Delay(-1) |> Async.AwaitTask |> Async.RunSynchronously
    8