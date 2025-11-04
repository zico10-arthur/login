# Projeto Login

Projeto de API de login em C# com arquitetura organizada em camadas e tratamento de regras de negócio.

Estrutura do projeto:
- Domain
  Contém as entidades do domínio (Conta) e exceções específicas (ContaExceptions).
- Application
  Camada de aplicação, com serviços (ContaService, ValidacoesService) e DTOs (ContaCreateDTO, ContaLoginDTO).
- Infrastructure
  Repositórios (ContaRepository) e banco de dados em memória (lista estática).
- Controllers
  API Controllers que recebem requisições e chamam os serviços.

Funcionalidades:
- Cadastrar uma conta (ContaCreateDTO)
- Autenticar login (ContaLoginDTO)
- Alterar senha
- Listar contas cadastradas

Padrões e boas práticas implementadas:
- Injeção de dependência (DI):
  Serviços e repositórios registrados no Program.cs usando AddScoped, permitindo desacoplamento e testabilidade.
- Validações separadas:
  ValidacoesService trata regras de negócio como validação de nome, email e senha.
- Exceções específicas:
  Cada tipo de erro possui uma exceção própria, evitando uso de Exception genérica.
- DTOs em implementação inicial:
  Camada Application já possui DTOs (ContaCreateDTO e ContaLoginDTO) para separar a API do domínio e proteger os dados.

Tecnologias:
- .NET 7 / ASP.NET Core
- C#
- Lista estática como banco de dados temporário

Próximos passos:
- Finalizar implementação completa dos DTOs no Controller e Service
- Adicionar DTOs de saída para proteger campos sensíveis
- Eventualmente substituir lista estática por banco de dados real
