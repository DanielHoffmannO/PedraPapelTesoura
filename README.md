🌐 [English](README.en.md) | [Español](README.es.md)

# ✊✋✌️ Pedra Papel Tesoura

![.NET 6](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?logo=windows&logoColor=white)
![License MIT](https://img.shields.io/badge/License-MIT-green)

> Jogo clássico com API REST + interface gráfica Windows Forms e arquitetura em camadas.

## 📸 Screenshot

![Pedra Papel Tesoura](https://user-images.githubusercontent.com/102805477/187693758-49d538b9-cf1b-469f-83d1-bb31fa9be846.png)

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 6)
- **Frontend:** Windows Forms (.NET 6)
- **Arquitetura:** Clean Architecture

## 🚀 Como Rodar

**Pré-requisitos:** .NET 6 SDK

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/PedraPapelTesoura.git
cd PedraPapelTesoura

# Inicie a API
dotnet run --project src/PedraPapelTesoura.Api

# Em outro terminal, inicie a interface
dotnet run --project src/PedraPapelTesoura.Tela
```

## 🏗️ Arquitetura

```
src/
├── PedraPapelTesoura.Domain/        # Entidades e regras de negócio
├── PedraPapelTesoura.Application/   # Casos de uso e interfaces
├── PedraPapelTesoura.Api/           # ASP.NET Core Web API
└── PedraPapelTesoura.Tela/          # Windows Forms (interface gráfica)
```

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

## 👤 Autor

Desenvolvido com ☕ por **[114995](https://github.com/114995)**
