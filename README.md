# Vibe Bingo Caller

A Blazor WebAssembly app for calling BINGO numbers at family events, built with Clean Architecture and Domain-Driven Design principles.

## Features
- Start a new BINGO round
- Call random balls (B, I, N, G, O with correct number ranges)
- Each ball can only be called once per round
- 5x16 grid display of all balls

## Architecture
- **Domain**: Core BINGO logic and entities
- **Application**: Use cases and services
- **Infrastructure**: Data persistence (if needed)
- **UI**: Blazor WASM frontend

## Getting Started
1. Open this folder in VS Code
2. Build and run the app:
   ```
dotnet run
   ```
3. Open the provided URL in your browser

---

This project is a work in progress. Contributions and suggestions are welcome!
