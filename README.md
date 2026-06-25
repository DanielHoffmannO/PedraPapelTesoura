[>] [English](README.en.md) | [Espanol](README.es.md)

# {v} Pedra Papel Tesoura

![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet)
![WinForms](https://img.shields.io/badge/Windows%20Forms-0078D6?logo=windows)
![License](https://img.shields.io/badge/license-MIT-green)

> Jogo classico com API REST + interface grafica Windows Forms e arquitetura em camadas.

## [~] Screenshot

![Captura de Tela do Jogo](https://user-images.githubusercontent.com/102805477/187693758-49d538b9-cf1b-469f-83d1-bb31fa9be846.png)

## {=} Tech Stack

- .NET 6 / ASP.NET Core Web API
- Windows Forms (.NET 6)
- Clean Architecture (Domain, Application, Api, Tela)

## [!] Como Rodar

```bash
# 1. Rode a API
dotnet run --project src/PedraPapelTesoura.Api

# 2. Rode o Forms
dotnet run --project src/PedraPapelTesoura.Tela
```

## {/} Arquitetura

```
src/
+-- PedraPapelTesoura.Domain       <- Modelos, Enums, Interfaces
+-- PedraPapelTesoura.Application  <- Logica do jogo, DI
+-- PedraPapelTesoura.Api          <- API REST (endpoints)
+-- PedraPapelTesoura.Tela         <- Windows Forms (UI)
```

## [$] Licenca

Este projeto esta sob a licenca [MIT](LICENSE).
