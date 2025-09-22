# 📧 Agenda de Emails

Uma aplicação simples em **C#/.NET** para gerenciar contatos com nome e email.

A finalidade deste projeto em sí não é a sua usabilidade, mas sim podemos testar ele com Xunit, e desenvolver ou aprimorar habilidades com testes unitários.

Inicialmente este projeto ultilizada de um banco de dados MySql, por finalidades acadêmicas, ele foi migrado para PostgreSql.

![Badge](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)  
![Badge](https://img.shields.io/badge/.NET-8.0-blue)  
![Badge](https://img.shields.io/badge/license-MIT-green)

---

## 🚀 **Começando**

### ✅ **Pré-requisitos**
- [.NET SDK](https://dotnet.microsoft.com/) (versão usada: **.NET 8.0** ou compatível)  
- IDE recomendada: Visual Studio / VS Code / Rider  
- Git instalado

### 📥 **Instalação**
1. Clone este repositório:  
   ```bash
   git clone https://github.com/romariobraz/Agenda-de-Emails.git
   ```
2. Acesse a pasta do projeto:  
   ```bash
   cd Agenda-de-Emails
   ```
3. Restaure pacotes e dependências:  
   ```bash
   dotnet restore
   ```
4. Execute a aplicação:  
   ```bash
   dotnet run --project Agenda
   ```

---

## 🗂 **Estrutura do Projeto**

```
Agenda-de-Emails/
├── Agenda/              # Código principal da aplicação
│   ├── Models/          # Modelos de dados
│   ├── Services/        # Serviços e lógica de banco de dados
│   └── Program.cs       # Ponto de entrada
├── Agenda.sln           # Solução do projeto
└── README.md            # Este arquivo
```

---

## ✨ **Funcionalidades**
- ➕ Adicionar novos contatos (nome + email)  
- 📋 Listar todos os contatos cadastrados  
- ✏️ Editar informações existentes  
- ❌ Remover contatos  

---

## 🛠 **Tecnologias Utilizadas**
- C#  
- .NET 8.0
- Windows Forms
- Npgsql (PostgreSQL)
- xUnit para testes 

---

## 🤝 **Como Contribuir**
1. Faça um fork do projeto.  
2. Crie uma branch para sua feature/correção:  
   ```bash
   git checkout -b feature/nova-feature
   ```
3. Faça commit das mudanças:  
   ```bash
   git commit -m "Adiciona nova feature"
   ```
4. Faça push para a branch:  
   ```bash
   git push origin feature/nova-feature
   ```
5. Abra um Pull Request explicando suas alterações.
---

## 📄 **Licença**
Este projeto está licenciado sob a licença [MIT].  
Sinta-se à vontade para usar, modificar e distribuir conforme necessário.

---
