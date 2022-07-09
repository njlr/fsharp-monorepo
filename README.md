# F# Monorepo Demo

Demonstration of a scalable F# monorepo.

_Status: Very WIP 🚧_

Technologies:

 - [F#](https://fsharp.org)
 - [.NET](https://dotnet.microsoft.com)
 - [Paket](https://fsprojects.github.io/Paket)
 - [Bazel](https://bazel.build)
 - [rules_dotnet](https://github.com/bazelbuild/rules_dotnet)
 - [Expecto](https://github.com/haf/expecto)

## Build

To build everything:

```bash
bazel build //...
```

## Run

To run a specific binary target:

```bash
bazel run //app
```

## Test

To run all tests:

```bash
bazel test //...
```

To run a specific test:

```bash
bazel test //tests
```

## Adding a Dependency

First fetch Paket from Nuget:

```bash
dotnet tool restore
```

Then add you dependency:

```bash
dotnet paket add Thoth.Json.Net
```

Then sync with Bazel:

```bash
./sync-paket-deps.sh
```

The `deps` list item in you Bazel files should like this:

```python
"@paket.main//thoth.json.net"
```
