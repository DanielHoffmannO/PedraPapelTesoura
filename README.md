ðŸŒ [English](README.en.md) | [EspaÃ±ol](README.es.md)

# âœŠâœ‹âœŒï¸ Pedra Papel Tesoura

![.NET 6](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?logo=windows&logoColor=white)
![License MIT](https://img.shields.io/badge/License-MIT-green)

> Jogo clÃ¡ssico com API REST + interface grÃ¡fica Windows Forms e arquitetura em camadas.

## ðŸ“¸ Screenshot

![Pedra Papel Tesoura](https://user-images.githubusercontent.com/102805477/187693758-49d538b9-cf1b-469f-83d1-bb31fa9be846.png)

## ðŸ› ï¸ Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 6)
- **Frontend:** Windows Forms (.NET 6)
- **Arquitetura:** Clean Architecture

## ðŸš€ Como Rodar

**PrÃ©-requisitos:** .NET 6 SDK

```bash
# Clone o repositÃ³rio
git clone https://github.com/seu-usuario/PedraPapelTesoura.git
cd PedraPapelTesoura

# Inicie a API
dotnet run --project src/PedraPapelTesoura.Api

# Em outro terminal, inicie a interface
dotnet run --project src/PedraPapelTesoura.Tela
```

## ðŸ—ï¸ Arquitetura

```
src/
â”œâ”€â”€ PedraPapelTesoura.Domain/        # Entidades e regras de negÃ³cio
â”œâ”€â”€ PedraPapelTesoura.Application/   # Casos de uso e interfaces
â”œâ”€â”€ PedraPapelTesoura.Api/           # ASP.NET Core Web API
â””â”€â”€ PedraPapelTesoura.Tela/          # Windows Forms (interface grÃ¡fica)
```

## ðŸ“„ LicenÃ§a

Este projeto estÃ¡ sob a licenÃ§a [MIT](LICENSE).

## ðŸ‘¤ Autor

Desenvolvido com â˜• por **[114995](https://github.com/114995)**
