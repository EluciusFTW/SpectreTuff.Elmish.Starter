open System
open Elmish
open SpectreTuff.Widgets
open SpectreTuff.Elmish

type Model = { LastKey: string }

type Msg = KeyPressed of ConsoleKeyInfo

let init () =
  { LastKey = "none" }, Cmd.none

let update msg model =
  match msg with
  | KeyPressed key when key.KeyChar = 'q' -> model, TuiCmd.exit
  | KeyPressed key -> { LastKey = string key.Key }, Cmd.none

let view model _dispatch =
  textBox $"Last key: {model.LastKey} (press q to quit)"

Program.mkProgram init update view
|> Program.withSubscription (fun _ -> Subscriptions.keys KeyPressed)
|> Tui.run
