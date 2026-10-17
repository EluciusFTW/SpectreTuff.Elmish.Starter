# SpectreTuff.Elmish Starter
A minimal starter for building terminal UIs in F# with [Elmish](https://github.com/elmish/elmish) on [SpectreTuff](https://github.com/EluciusFTW/SpectreTuff).

## Getting started
Click **Use this template** on GitHub to create your own repository, then:

```sh
dotnet run
```

The app shows the last key you pressed; press `q` to quit.

## What's inside
- `Program.fs` – the whole app: model, messages, `update`, `view`, and the program wiring
- `App.fsproj` – references [`EluciusFTW.SpectreTuff.Elmish`](https://www.nuget.org/packages/EluciusFTW.SpectreTuff.Elmish)

Rename `App.fsproj` to suit your project.

## Next steps
- For periodic updates, add `Subscriptions.tick (TimeSpan.FromSeconds 1.0) Tick` to the subscriptions.
- To forward a child component's subscriptions to its parent, use Elmish's `Sub.map "child" ChildMsg childSubs`.
- Use `SpectreTuff.Keymap` to drive both key handling and the help bar from one list of bindings – see the [SpectreTuff README](https://github.com/EluciusFTW/SpectreTuff#key-bindings).

> [!WARNING]
> SpectreTuff, as well as Spectre.Tui, is currently under construction and may change at any time.
