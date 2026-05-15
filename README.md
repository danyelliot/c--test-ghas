# c--test-ghas

A simple C# console application demonstrating GitHub Advanced Security (GHAS) workflows.

## Project Structure

```
.
├── src/
│   └── SimpleApp/         # C# console application
│       ├── Calculator.cs  # Basic arithmetic operations
│       ├── Greeter.cs     # Greeting utility
│       └── Program.cs     # Application entry point
├── .github/
│   ├── workflows/
│   │   └── codeql.yml     # CodeQL code scanning workflow
│   └── dependabot.yml     # Dependabot dependency update config
└── SimpleApp.slnx         # Solution file
```

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run --project src/SimpleApp
```

## Security Workflows

### CodeQL

The [CodeQL workflow](.github/workflows/codeql.yml) runs on:
- Every push to `main`
- Every pull request targeting `main`
- Weekly on Mondays at 08:00 UTC

It performs static analysis on the C# source code to detect potential security vulnerabilities.

### Dependabot

[Dependabot](.github/dependabot.yml) is configured to automatically open pull requests for:
- **NuGet** packages — weekly on Mondays
- **GitHub Actions** — weekly on Mondays