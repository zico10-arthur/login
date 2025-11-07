# Projeto de Sistema de Login em C#

Este é um projeto de exemplo de sistema de login implementado em C#, seguindo boas práticas de DDD (Domain-Driven Design), Repository Pattern e separação de camadas. O projeto usa DTOs para transferência de dados e listas na memória, mas também pode ser adaptado para bancos de dados reais.

---

## Estrutura do Projeto

Domain/
  - Entities/Conta.cs
  - Interfaces/IContaRepository.cs
  - Interfaces/IDataBase.cs
  - ContaExceptions/

Application/
  - Dtos/
      - CriarContaDTO.cs
      - AlterarSenhaDTO.cs
      - AutenticarDTO.cs
  - Service/ValidacoesService.cs
  - Service/ContaService.cs

Infraestructure/
  - Data/DataBase.cs
  - Repository/ContaRepository.cs

Program.cs

---

## Tecnologias Utilizadas

- C# 12
- .NET 8
- ASP.NET Core Web API
- Postman (para testes)
- DDD (Domain-Driven Design)
- Repository Pattern
- DTOs para entrada/saída de dados

---

## Funcionalidades

- Cadastro de usuário (nome, sobrenome, email, senha)
- Autenticação de usuário (login)
- Alteração de senha
- Listagem de contas
- Validações de negócio:
  - Nome e sobrenome não podem estar vazios e devem conter apenas letras e espaços
  - Email deve ser válido
  - Senha deve ter pelo menos 8 caracteres, incluir letras, números e caracteres especiais
  - Login valida se email e senha foram preenchidos
- Estrutura pronta para migrar para banco de dados real

---
## Boas Práticas Implementadas

- Separação de camadas: Domain → Application → Infraestructure
- Uso de DTOs para não expor entidades do domínio
- Validações centralizadas no serviço ValidacoesService
- Repository Pattern desacoplando regras de negócio da persistência
- Injeção de dependência para flexibilidade

---
